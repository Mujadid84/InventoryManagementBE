using InventoryManagement.Contracts.DLContracts;
using InventoryManagement.Entities;
using InventoryManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryManagement.Repository
{
    public class ProductRepository: RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void DeleteProduct(int productId)
        {
            var product = FindByCondition(p => p.ProductID == productId).FirstOrDefault();
            Delete(product);
            RepositoryContext.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return RepositoryContext.Products.ToList();
        }
        public Product GetProductById(int productId)
        {
            return FindByCondition(p => p.ProductID == productId).FirstOrDefault();
        }

        public void Insert(Product product)
        {
            Create(product);
            RepositoryContext.SaveChanges();
        }

        public void Update(Product product)
        {
            base.Update(product);
            RepositoryContext.SaveChanges();
        }
    }
}
