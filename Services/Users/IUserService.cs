using Core.Domain;
using System.Linq;

namespace Services.Users
{
    public interface IUserService
    {
        int GetCountOfItemsInCart(int userId);
        IQueryable<Cart> GetItemsInCart(int userId);
        void DeleteItemInCart(int userId, int productId);
        void AddItemToCart(int userId, int productId);
    }
}