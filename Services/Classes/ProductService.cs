using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Data.Classes;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Extensions;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Classes;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces;

namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Services.Classes
{
    public class ProductService : IPromotion
    {
        private readonly ProductData _productData;
        private readonly IDiscount _discount;
        private List<CartItem> _products = new List<CartItem>();
        public ProductService(ProductData productData, IDiscount discount)
        {
            _productData = productData;
            _discount = discount;
        }
        public List<CartItem> GetCartItems(ICart cart)
        {
            GetFreeItems(cart);
            ApplyPromotion(cart);
            return _products;
        }

        public bool IsApplicable(ICart cart)
        {
            if (cart.GetTotalPrice() > 50)
            {
                return true;
            }
            return false;
        }

        public void ApplyPromotion(ICart cart)
        {
            var discountPrice = cart.GetTotalPrice();
            if (IsApplicable(cart) is true)
            {
                // calc the promotion
                _discount.ApplyDiscount(discountPrice);
            }
       

        }

        private void GetFreeItems(ICart cart)
        {
            var currentCart = cart.GetItems();
            var cartProduts = cart.GetItems()
                                  .Where(x => x.Product.ProductSKUEquals("SKU005"))
                                  .ToList();
            _products.AddRange(cartProduts);
            _products.AddRange(currentCart);
        }
    }
}
