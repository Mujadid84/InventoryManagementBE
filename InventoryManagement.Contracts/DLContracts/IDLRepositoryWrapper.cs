using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Contracts.DLContracts
{
    public interface IDLRepositoryWrapper
    {
        IProductRepository Product { get; }
        void Save();
    }
}
