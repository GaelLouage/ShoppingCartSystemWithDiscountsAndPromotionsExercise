using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Classes;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces;
using System.Runtime.CompilerServices;

namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Data.Classes
{
    public  class ProductData
    {
        private List<IProduct> _products = new List<IProduct>
        {
            new Product { Name = "Product 1", Price = 19.99m, SKU = "SKU001" },
            new Product { Name = "Product 2", Price = 29.99m, SKU = "SKU002" },
            new Product { Name = "Product 3", Price = 9.99m, SKU = "SKU003" },
            new Product { Name = "Product 4", Price = 49.99m, SKU = "SKU004" },
            new Product { Name = "Product 5", Price = 99.99m, SKU = "SKU005" },
            new Product { Name = "Product 5", Price = 99.99m, SKU = "SKU005" },
            new Product { Name = "Product 5", Price = 99.99m, SKU = "SKU005" },
            new Product { Name = "Product 5", Price = 99.99m, SKU = "SKU005" },
        };
        public List<IProduct> GetProducts() => _products;
    }
}
