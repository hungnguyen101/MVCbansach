using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCbansach.Models
{
    public class Item
    {
        private ProductService.Product pr = new ProductService.Product();

        public ProductService.Product Pr
        {
            get { return pr; }
            set { pr = value; }
        }

        
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Item()
        {

        }
        public Item(ProductService.Product product, int quantity)
        {
            this.Pr = product;
            this.Quantity = quantity;
        }
    }
}