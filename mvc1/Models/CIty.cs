using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace mvc1.Models
{
    public class CIty
    {
        public static IEnumerable GetCities(string country)
        {
            Model1 dbcontext = new Model1();
            var getlist = dbcontext.Categories.ToList();



            List<object> data = new List<object>();

            foreach (var myitem in getlist)
            {
                Guid id = myitem.CategoryID;
                string name = myitem.Name;

                data.Add(new { Id = id, Name = name });
            }

            return data;
        }
    }
}