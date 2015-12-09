using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCbansach.Models;
using PagedList;
using PagedList.Mvc;
using MVCbansach.ProductService;
using MVCbansach.ProductCategoryService;

namespace MVCbansach.Controllers
{
    public class ProductController : Controller
    {
        ProductService.ProductClient productServ = new ProductService.ProductClient();
        ProductCategoryService.CategoryClient proCategoryServ = new ProductCategoryService.CategoryClient();

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
                List<ProductService.Product> model = productServ.findProductsByCategory(Convert.ToInt32(id)).ToList();
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
        public ActionResult SearchProduct(string keyword, int page = 1, int pageSize = 12)
        {
            //1-0.000 ₫- 100.000 ₫    2-100.000 ₫- 500.000 ₫   3-trên 500.000 ₫
            List<ProductService.Product> model = productServ.findByKeyword(keyword).ToList();
            

            ////if (keyword == null)
            ////{
            ////    keyword = "";
            ////}
            ////model = productServ.findAll().ToList();
            ////if (checkboxVal == 1)
            ////{
            ////  model =  productServ.findByPrice(0, 100000).ToList();//1
            ////}
            ////else if (checkboxVal == 2)
            ////{
            ////    model = productServ.findByPrice(100000, 500000).ToList();//2
            ////}
            ////else if (checkboxVal == 3)
            ////{
            ////    productServ.findByPrice(500000, 1000000);//3
            ////}                     
            return View(model.ToPagedList(page, pageSize));
        }

        public ActionResult ProductDetail(int id)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }else{
                ProductService.Product product = productServ.findById(Convert.ToInt64(id));
                if (product == null)
                {
                    return HttpNotFound();
                }
                return View(product);
            }           
        }
        public PartialViewResult _NavMenuPartial()
        {

            List<ProductCategoryService.Category> product = proCategoryServ.findAll().ToList();
            return PartialView(product);
        }

        public PartialViewResult RelatedProducts()
        {
            var _idRul = Url.RequestContext.RouteData.Values["id"];
            long id = Convert.ToInt64(_idRul);
            ProductService.Product CurrentProduct = productServ.findById(id);
            List<ProductService.Product> products = productServ.findProductsByCategory(Convert.ToInt32(CurrentProduct.Category)).ToList();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].id == id)
                {
                    products.RemoveAt(i);
                }
            }
            return PartialView(products);          
        }
        public PartialViewResult _SearchProduct()
        {
            return PartialView();
        }
        public PartialViewResult LeftProductCategory()
        {
            List<ProductCategoryService.Category> product = proCategoryServ.findAll().ToList();
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