using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces;

namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Classes
{
    public class CartItem
    {
        public IProduct Product { get; set; }
        public int Quantity { get; set; }
    }
}
