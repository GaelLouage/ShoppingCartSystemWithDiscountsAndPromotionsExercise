using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces;

namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Classes
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string SKU { get; set; }
    }
}
