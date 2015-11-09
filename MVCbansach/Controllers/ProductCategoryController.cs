using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCbansach.ProductCategoryService;

namespace MVCbansach.Controllers
{
    public class ProductCategoryController : Controller
    {
        ProductCategoryService.CategoryClient proCategoryServ = new ProductCategoryService.CategoryClient();
        // GET: ProductCategory
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _NavMenuPartial()
        {
            List<ProductCategoryService.Category> productCategory = proCategoryServ.findAll().ToList();
            return PartialView(productCategory);
        }

    }
}