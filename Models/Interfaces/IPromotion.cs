namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces
{
    public interface IPromotion
    {
        bool IsApplicable(ICart cart);
        void ApplyPromotion(ICart cart);
    }
}
