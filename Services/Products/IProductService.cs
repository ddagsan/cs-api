using Core.Domain;
using Core.Models.Enums;
using System.Linq;

namespace Services.Products
{
    public interface IProductService
    {
        IQueryable<Product> Get(string name, int? colorId, int? brandId, SortType sortType);
    }
}