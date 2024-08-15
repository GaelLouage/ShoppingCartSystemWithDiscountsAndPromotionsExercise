using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Classes;

namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces
{
    public interface ICart
    {
        void AddProduct(IProduct product, int quantity);
        void RemoveProduct(IProduct product);
        decimal GetTotalPrice();
        List<CartItem> GetItems();
    }
}
