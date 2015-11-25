using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCbansach.Models;

namespace MVCbansach.Controllers
{
    public class CheckoutController : Controller
    {
        OrderService.OrderClient OrderSer = new OrderService.OrderClient();
        // GET: Checkout
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OrderConfirm()
        {
            OrderService.Order Order = new OrderService.Order();
            Order.Account = (int)Session["userid"];
            Order.CreatedAt = DateTime.Now;
            Order.Status = false;
            Order.Information = "abcd";

            List<OrderService.DetailOrder> orderDetail = new List<OrderService.DetailOrder>();
            OrderService.DetailOrder items = new  OrderService.DetailOrder();
            foreach (Item item in (List<Item>)Session["cart"]){
                items.ProductId = Convert.ToInt32(item.Pr.id);
                items.Quantity = item.Pr.Quantity;
            }
            orderDetail.Add(items);

            OrderSer.insert(Order, orderDetail.ToArray());
            return RedirectToAction("Index", "Home");
        }
    }
}