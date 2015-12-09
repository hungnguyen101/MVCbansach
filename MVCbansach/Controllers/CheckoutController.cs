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
        ProductService.ProductClient ProductSer = new ProductService.ProductClient();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OrderConfirm()
        {
            if (Session["userid"] == null)
            {
                Session["WarningMessage"] = "Vui lòng đăng nhập trước khi thanh toán hoặc tạo tài khoản nếu bạn không phải thành viên.";
                return RedirectToAction("Login", "Account");
            }
            else
            {
                // create an order
                OrderService.Order Order = new OrderService.Order();
                Order.Account = (int)Session["userid"];
                Order.CreatedAt = DateTime.Now;
                Order.Status = false;

                // create a detail order list
                List<OrderService.DetailOrder> ListOrderDetail = new List<OrderService.DetailOrder>();
                OrderService.DetailOrder OrderDetail = new OrderService.DetailOrder();
                List<Item> itemInCart = (List<Item>)Session["cart"];
                foreach (Item item in itemInCart)
                {
                    ListOrderDetail.Add(new OrderService.DetailOrder() { ProductId = Convert.ToInt32(item.Pr.id), Quantity = item.Quantity });
                }
                // insert to database
                OrderSer.insert(Order, ListOrderDetail.ToArray());
                Session["SuccessMessage"] = "Mua hàng thành công";
                return RedirectToAction("CheckoutList", "Checkout");
            }    
        }
        public ActionResult CheckoutList()
        {            
            long userId = Convert.ToInt64(Session["userid"]);
            List<OrderService.Order> list_order = OrderSer.findOrderByAccount(userId).ToList();
            return View(list_order);
        }
        public ActionResult CheckoutDetail(long OrderId)
        {
            ViewBag.OrderId = OrderId;
            long userId = Convert.ToInt64(Session["userid"]);
            List<OrderService.DetailOrder> OrderDetail = OrderSer.findDetailByOrder(OrderId).ToList();           
            List<Item> ListItem = new List<Item>();
            foreach (var item in OrderDetail)
            {
                ProductService.Product product = ProductSer.findById(item.ProductId);
                Item newitem = new Item();
                newitem.Pr = product;
                newitem.Quantity = Convert.ToInt32(item.Quantity);
                ListItem.Add(newitem);
            }
            return View(ListItem);
        }

    }
}