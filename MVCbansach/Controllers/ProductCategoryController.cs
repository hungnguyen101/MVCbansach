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
        ProductCategoryService.ProductCategoryClient proCategoryServ = new ProductCategoryService.ProductCategoryClient();
        // GET: ProductCategory
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _NavMenuPartial()
        {
            List<ProductCategoryService.ProductCategory> productCategory = proCategoryServ.findAll().ToList();
            return PartialView(productCategory);
        }

    }
}