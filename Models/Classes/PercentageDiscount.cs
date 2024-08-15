using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces;

namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Classes
{
    public class PercentageDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal totalPrice)
        {
            return totalPrice;
        }
    }
}
