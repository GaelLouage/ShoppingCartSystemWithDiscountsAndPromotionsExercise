using Microsoft.AspNetCore.Mvc;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Data.Classes;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Classes;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces;

namespace ShoppingCartSystemWithDiscountsAndPromotionsExercise.Services.Classes
{
    public class ShoppingCart : ICart
    {
    

        private List<CartItem> _items = new List<CartItem>();
        public void AddProduct(IProduct product, int quantity)
        {
            for(int i = 0; i< quantity; i++)
            {
                _items.Add(new CartItem { Product = product, Quantity = 1 });
            }
        }

        public List<CartItem> GetItems()
        {
            return _items;
        }

        public decimal GetTotalPrice()
        {
            var productData = new ProductData();
            var products = productData.GetProducts();
            var totalPrice = 0M;
            foreach(var product in products) 
            {
                foreach(var item in _items)
                {
                    if(item.Product.Name == product.Name)
                    {
                        totalPrice += product.Price;
                    }
                }
            }
            return totalPrice;
        }

        public void RemoveProduct(IProduct product)
        {
            var productInList = _items.FirstOrDefault(x => x.Product.Name == product.Name);
            if (productInList is not null)
            {
                _items.Remove(productInList);
            }
        }
    }
}
