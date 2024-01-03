using InventoryManagement.Contracts.DLContracts;
using InventoryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Repository
{
    public class RepositoryWrapper: IDLRepositoryWrapper
    {
        private RepositoryContext _repoContext;

        private IProductRepository _product;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_repoContext);
                }

                return _product;
            }
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
