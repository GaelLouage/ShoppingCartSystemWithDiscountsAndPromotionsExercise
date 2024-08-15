using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces;

namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Classes
{
    public class FixedAmountDiscount : IDiscount
    {
        // only applied if sum of products is bigger than 50
        public decimal ApplyDiscount(decimal totalPrice)
        {
            //5 % discount on orders above 50
            return totalPrice * 0.05M;
        }
    }
}
