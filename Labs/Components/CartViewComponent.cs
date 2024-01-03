using Labs.Extensions;
using Labs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labs.Components;

public class CartViewComponent : ViewComponent
{
    private Cart _cart;
    public CartViewComponent(Cart cart)
    {
        _cart = cart;
    }

    public IViewComponentResult Invoke()
    {
        var cart = HttpContext.Session.Get<Cart>("cart");
        return View(cart);
    }
}