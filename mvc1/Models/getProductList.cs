using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc1.Models
{
    public class getProductList
    {
        public static IEnumerable GetProducts()
        {
            Model1 dbcontext = new Model1();
            var getlist = dbcontext.Products.ToList();



            List<object> data = new List<object>();

            foreach (var myitem in getlist)
            {
                Guid id = myitem.ProductID;
                string name = myitem.Name;
                decimal? unitPrice = myitem.UnitPrice;
                Guid? catId = myitem.CategoryID;


                data.Add(new { Id = id, Name = name, UnitPrice = unitPrice, catId=catId });
            }

            return data;
        }
    }
}