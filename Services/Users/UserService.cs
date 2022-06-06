using Core.Data;
using Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Services.Users
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Cart> _cartRepository;
        private readonly IRepository<Product> _productRepository;
        public UserService(
                IRepository<User> userRepository,
                IRepository<Cart> cartRepository,
                IRepository<Product> productRepository
            )
        {
            _userRepository = userRepository;
            _cartRepository = cartRepository;
            _productRepository = productRepository;
        }

        public void AddItemToCart(int userId, int productId)
        {
            //var product = _productRepository.Table.First(m => m.Id == productId);
            var cartItem = new Cart() 
            { 
                UserId = userId,
                ProductId = productId,
                DateCreated = DateTime.Now
            };
            _cartRepository.Insert(cartItem);
        }

        public void DeleteItemInCart(int userId, int productId)
        {
            var cart = _cartRepository.Table.First(m => m.UserId == userId && m.ProductId == productId);
            _cartRepository.Delete(cart);
        }

        public int GetCountOfItemsInCart(int userId)
        {
            return userItemsInCart(userId).Count();
        }

        public IQueryable<Cart> GetItemsInCart(int userId)
        {
            return userItemsInCart(userId).OrderBy(m => m.DateCreated);
        }

        private IQueryable<Cart> userItemsInCart(int userId) 
        {
            return _cartRepository.Table.Where(m => m.UserId == userId);
        }
    }
}
