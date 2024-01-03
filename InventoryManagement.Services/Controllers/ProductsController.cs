using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagement.Contracts.DLContracts;
using InventoryManagement.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InventoryManagement.Services.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductsController : ControllerBase
    {

        private readonly ILogger<ProductsController> _logger;

        private IDLRepositoryWrapper _repoWrapper;

        public ProductsController(ILogger<ProductsController> logger, IDLRepositoryWrapper repoWrapper)
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _repoWrapper.Product.GetAllProducts();
        }

        [HttpGet]
        public Product GetProductById(int productId)
        {
            return _repoWrapper.Product.GetProductById(productId);
        }

        [HttpPost]
        public void DeleteProduct(int productId)
        {
            _repoWrapper.Product.DeleteProduct(productId);
        }

        [HttpPost]
        public void InsertProduct(Product product)
        {
            _repoWrapper.Product.Insert(product);
        }

        [HttpPost]
        public void UpdateProduct(Product product)
        {
            _repoWrapper.Product.Update(product);
        }
    }
}
