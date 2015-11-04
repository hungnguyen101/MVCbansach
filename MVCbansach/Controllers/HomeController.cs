using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCbansach.Models;

namespace MVCbansach.Controllers
{
    public class HomeController : Controller
    {
        BookStoreOnlineEntities db = new BookStoreOnlineEntities();
        ProductService.ProductClient productServ = new ProductService.ProductClient();
        ProductCategoryService.ProductCategoryClient productCategoryServ = new ProductCategoryService.ProductCategoryClient();
        // GET: TrangChu
        public ActionResult Index()
        {
            ViewBag.Title = "Bán sách";
            List<ProductService.Product> model = productServ.findAll().ToList();
            return View(model);
        }
        public PartialViewResult Part()
        {
            return PartialView(db.Products.Take(10).ToList());
        }
    }
}