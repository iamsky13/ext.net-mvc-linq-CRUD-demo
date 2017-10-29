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
            List<object> data1 = new List<object>();
            foreach (var myitem in getlist)
            {
                Guid id = myitem.CategoryID;
                string name = myitem.Name;
                data1.Add(new { Id = id, Name = name });
            }

            ViewBag.CatList = data1;
            return View(Companies.GetAllCompanies());

        }

        public ActionResult GetCities(string country)
        {
            return this.Store(CIty.GetCities(country));
        }
        public ActionResult submitdata(Category cat)
        {
            return View();
        }

        [DirectMethod]
        public ActionResult LogCompanyInfo(String name, Guid Id)
        {
           

            return this.Direct();
        }
    }
}