namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal totalPrice);
    }
}
