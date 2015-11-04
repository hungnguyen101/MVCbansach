using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCbansach.Models;
using PagedList;
using PagedList.Mvc;
using MVCbansach.ProductService;

namespace MVCbansach.Controllers
{
    public class ProductController : Controller
    {
        ProductService.ProductClient productServ = new ProductService.ProductClient();
        ProductCategoryService.ProductCategoryClient proCategoryServ = new ProductCategoryService.ProductCategoryClient();

        // GET: Product
        public ActionResult AllProduct(int page=1, int pageSize = 12)
        {
            List<ProductService.Product> model = null;
            model = productServ.findAll().ToList();
            return View(model.ToPagedList(page, pageSize));
        }
        public ActionResult ProductByCategory(int page = 1, int pageSize = 12)
        {
            var _idRul = Url.RequestContext.RouteData.Values["id"];
            if (_idRul == null)
            {
                return HttpNotFound();
            }
            else
            {
                long id = Convert.ToInt64(_idRul);
                List<ProductService.Product> model = productServ.findProuctsByCategory((int)id).ToList();
                if (model == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(model.ToPagedList(page, pageSize));
                }     
            }        

        }

        public ActionResult ProductDetail()
        {
            var _idRul = Url.RequestContext.RouteData.Values["id"];
            if (_idRul == null)
            {
                return HttpNotFound();
            }else{
                long id = Convert.ToInt64(_idRul);
                ProductService.Product product = productServ.findById((long)id);
                if (product == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(product);
                }
            }           
        }
        public PartialViewResult _NavMenuPartial()
        {
            List<ProductCategoryService.ProductCategory> product = proCategoryServ.findAll().ToList();
            return PartialView(product);
        }
        public PartialViewResult _SearchProduct()
        {
            return PartialView();
        }
        public PartialViewResult LeftProductCategory()
        {
            List<ProductCategoryService.ProductCategory> product = proCategoryServ.findAll().ToList();
            return PartialView(product);
        }
        public PartialViewResult LeftTopHot()
        {
            List<ProductService.Product> products = productServ.findAll().OrderBy(n=>n.CreatedAt).Take(5).ToList();
            return PartialView(products);
        }
        public PartialViewResult LeftNewArrivedProduct()
        {
            List<ProductService.Product> products = productServ.findAll().OrderBy(n => n.CreatedAt).Take(5).ToList();
            return PartialView(products);
        }
        public PartialViewResult LeftPromotionProduct()
        {
            List<ProductService.Product> products = productServ.findAll().OrderBy(n => n.PromotionPrice).Take(5).ToList();
            return PartialView(products);
        }
        public PartialViewResult LeftFilter()
        {
            return PartialView();
        }
    }
}