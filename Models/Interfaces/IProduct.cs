namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
        string SKU { get; set; }
    }
}