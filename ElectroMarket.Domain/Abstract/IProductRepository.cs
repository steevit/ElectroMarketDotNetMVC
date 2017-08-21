using System.Collections.Generic;
using ElectroMarket.Domain.Entities;

namespace ElectroMarket.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
