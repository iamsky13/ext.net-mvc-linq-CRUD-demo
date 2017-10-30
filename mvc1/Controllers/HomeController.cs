using Ext.Net;
using Ext.Net.MVC;
using mvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult grid()
        {
            
            Model1 dbcontext = new Model1();
            var getlist = dbcontext.Categories.ToList();
            //SelectList list = new SelectList(getlist, "CategoryID", "Name");
            Category category = new Category();
            List<Category> data = dbcontext.Categories.ToList();
            
            return View(getProductList.GetProducts());

        }

        public ActionResult GetCities(string country)
        {
            return this.Store(CIty.GetCities(country));
        }

        public DirectResult Edit(Guid id, string name, decimal? price)
        {
            string message = "<b>Property:</b> {0}<br /><b>Field:</b> {1}<br /><b>Old Value:</b> {2}<br /><b>New Value:</b> {3}";

            // Send Message...
            X.Msg.Notify(new NotificationConfig()
            {
                Title = "Edit Record #" + id.ToString(),
                Html = string.Format(message, id),
                Width = 250,
                Height = 150
            }).Show();

            X.GetCmp<Store>("Store1").GetById(id).Commit();

            return this.Direct();
        }

        public RedirectToRouteResult SampleAction(string message, Guid ComboBoxCity)
        {
            Model1 dbcontext = new Model1();
            Product product = new Product();
            product.Name = message;
            product.CategoryID = ComboBoxCity;
            product.ProductID = Guid.NewGuid();
            using (dbcontext)
            {
                dbcontext.Products.Add(product);
                dbcontext.SaveChanges();
            }

            return RedirectToAction("grid");
        }
        
    }
}