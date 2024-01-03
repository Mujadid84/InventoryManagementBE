using InventoryManagement.Entities.Models;
using System.Collections.Generic;

namespace InventoryManagement.Contracts.DLContracts
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();

        Product GetProductById(int productId);

        void DeleteProduct(int productId);

        void Insert(Product product);

        void Update(Product product);
    }
}
