using System.Collections.Generic;
using ElectronicsStore.Domain.Entities;

namespace ElectronicsStore.Domain.Abstract {
    public interface IProductRepository {

        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}