using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Data.Classes;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Classes;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces;

namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Extensions
{
    public static class ProductExtensions
    {
        public static bool IsInStock(this Product product, ProductData productData)
        {
            return IsInStockValidation(product, productData);
        }

        public static bool ProductSKUEquals(this IProduct product, string SKU)
        {
            if (product.SKU.Equals(SKU)) 
            {
                return true;
            }
            return false;
        }
        public static bool IsInStockValidation(this Product product, ProductData productData)
        {
            var stock = productData.GetProducts();
            if (stock is null)
            {
                return false;
            }
            var findProduct = stock.Exists(x => x.Name.Equals(product.Name));
            if (findProduct is false)
            {
                return false;
            }
            return true;
        }
    }
}
