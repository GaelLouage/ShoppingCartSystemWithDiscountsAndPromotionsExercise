using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Data.Classes;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Classes;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Models.Interfaces;
using ShoppingCartSystemWithDiscountsAndPromotionsExercise.Services.Classes;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICart, ShoppingCart>();



var app = builder.Build();

app.MapGet("/", (ICart cart) => 
{
    var productService = new ProductService(new ProductData(), new FixedAmountDiscount());
    var products = new ProductData();
    var productsList = products.GetProducts();

    var productWithSKU004 = productsList.FirstOrDefault(x => x.SKU == "SKU004");
    var productWithSKU005 = productsList.FirstOrDefault(x => x.SKU == "SKU005");
    cart.AddProduct(productWithSKU005,2);
    cart.AddProduct(productWithSKU004 ,1);
    var productsAfterPromo = productService.GetCartItems(cart);
    
    
    return productsAfterPromo.Select(x => x.Product.Name).ToList();
});

app.Run();
