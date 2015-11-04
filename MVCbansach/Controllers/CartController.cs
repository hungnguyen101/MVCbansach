using MVCbansach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCbansach.Controllers
{
    public class CartController : Controller
    {

        ProductService.ProductClient ProServ = new ProductService.ProductClient();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _Cart()
        {
            return PartialView();
        }
        private int isExisting(long id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Pr.id == id)
                    return i;
            }
            return -1;
        }
        private decimal Total()
        {
            decimal total = 0;
            List<Item> cart = (List<Item>)Session["cart"];  
            for (int i = 0; i < cart.Count; i++)
            {
                total = cart[i].Quantity * (decimal)cart[i].Pr.PromotionPrice;
            }
            return total;
        }
        public ActionResult Delete()
        {
            var _idRul = Url.RequestContext.RouteData.Values["id"];
            if (_idRul == null)
            {
                return HttpNotFound();
            }
            else
            {
                long ItemId = Convert.ToInt64(_idRul);
                // cart exist
                List<Item> cart = (List<Item>)Session["cart"];
                ProductService.Product product = ProServ.findById(ItemId);
                int index = isExisting(ItemId);
                cart.RemoveAt(index);
                Session["cart"] = cart;
                return Redirect(Request.UrlReferrer.ToString());
            }
        }
        // chưa viết
        public ActionResult Update()
        {
            var _idRul = Url.RequestContext.RouteData.Values["id"];
            if (_idRul == null)
            {
                return HttpNotFound();
            }
            else
            {
                long ItemId = Convert.ToInt64(_idRul);
                // cart exist
                List<Item> cart = (List<Item>)Session["cart"];
                ProductService.Product product = ProServ.findById(ItemId);
                int index = isExisting(ItemId);
                cart.RemoveAt(index);
                Session["cart"] = cart;
                return Redirect(Request.UrlReferrer.ToString());
            }
        }
        public ActionResult OrderNow()
        {
            var _idRul = Url.RequestContext.RouteData.Values["id"];
            if (_idRul == null)
            {
                return HttpNotFound();
            }
            else
            {
                long ItemId = Convert.ToInt64(_idRul);
                //create cart 
                if (Session["cart"] == null)
                {
                    List<Item> cart = new List<Item>();
                    ProductService.Product product = ProServ.findById(ItemId);
                    cart.Add(new Item(product, 1));
                    Session["cart"] = cart;
                    return Redirect(Request.UrlReferrer.ToString());
                }
                else
                {
                    // cart exist
                    List<Item> cart = (List<Item>)Session["cart"];
                    ProductService.Product product = ProServ.findById(ItemId);
                    

                    int index = isExisting(ItemId);
                    if (index == -1)
                    {
                        cart.Add(new Item(product, 1));
                    }
                    else
                    {
                        // item exist -> increase quantity
                        cart[index].Quantity++;
                    }
                    
                    Session["cart"] = cart;
                    return Redirect(Request.UrlReferrer.ToString());
                } 
            }     
        }
    }
}