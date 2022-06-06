using Core.Data;
using Core.Domain;
using Core.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(
            IRepository<Product> productRepository
            )
        {
            _productRepository = productRepository;
        }

        public IQueryable<Product> Get(string name, int? colorId, int? brandId, SortType sortType)
        {
            IQueryable<Product> query = _productRepository.Table.Include(m => m.Brand).Include(m => m.Color);

            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(m => m.Name == name); //HACK: case insensitive kontrolü için kontrol edilmeli
            if (colorId.HasValue)
                query = query.Where(m => m.ColorId == colorId.Value);
            if (brandId.HasValue)
                query = query.Where(m => m.BrandId == brandId.Value);

            switch (sortType)
            {
                case SortType.LowestFirst:
                    query = query.OrderBy(m => m.Price);
                    break;
                case SortType.HighestFirst:
                    query = query.OrderByDescending(m => m.Price);
                    break;
                default:
                case SortType.AtoZ:
                    query = query.OrderBy(m => m.Name);
                    break;
                case SortType.ZtoA:
                    query = query.OrderByDescending(m => m.Name);
                    break;
            }

            return query;//.Skip(index * take).Take(take);
        }
    }
}
