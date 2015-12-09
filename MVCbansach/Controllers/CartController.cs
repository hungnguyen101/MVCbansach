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
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return HttpNotFound();
            }
            else
            {
                long ItemId = Convert.ToInt64(id);
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
        public ActionResult UpdateQuantity(int ProId, int quantity=1)
        {
                // cart exist
                List<Item> cart = (List<Item>)Session["cart"];
                ProductService.Product product = ProServ.findById(ProId);
                int index = isExisting(ProId);
                if (quantity == 0)
                {
                    cart.RemoveAt(index);
                    Session["SuccessMessage"] = "Xóa sản phẩm khỏi giỏ hàng thành công!";
                }
                else
                {
                    cart.RemoveAt(index);
                    cart.Add(new Item(product, quantity));
                    Session["cart"] = cart;
                    Session["SuccessMessage"] = "Cập nhật số lượng sản phẩm thành công!";
                }
                return RedirectToAction("Index", "Cart");
        }
        public ActionResult OrderNow(int id, int quantity = 1)
        {
            if (id <= 0)
            {
                return HttpNotFound();
            }
            else
            {
                long ItemId = Convert.ToInt64(id);
                //create cart 
                if (Session["cart"] == null)
                {
                    List<Item> cart = new List<Item>();
                    ProductService.Product product = ProServ.findById(ItemId);
                    cart.Add(new Item(product, quantity));
                    Session["cart"] = cart;
                    Session["SuccessMessage"] = "Bạn vừa thêm một sản phẩm vào giỏ hàng";
                    return RedirectToAction("Index", "Cart");
                }
                else
                {
                    // cart exist
                    List<Item> cart = (List<Item>)Session["cart"];
                    ProductService.Product product = ProServ.findById(ItemId);
                    

                    int index = isExisting(ItemId);
                    if (index == -1)
                    {
                        cart.Add(new Item(product, quantity));
                        Session["SuccessMessage"] = "Bạn vừa thêm một sản phẩm vào giỏ hàng";
                    }
                    else
                    {
                        // item exist -> increase quantity
                        cart[index].Quantity = cart[index].Quantity + quantity;
                        Session["SuccessMessage"] = "Bạn vừa cập nhật một sản phẩm vào giỏ hàng";
                    }
                    
                    Session["cart"] = cart;
                    return RedirectToAction("Index", "Cart");
                } 
            }     
        }

    }
}