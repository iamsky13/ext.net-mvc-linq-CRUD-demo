using System.Web.Mvc;
using Ext.Net;
using Ext.Net.MVC;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class ExtNetController : Controller
    {
        public ActionResult Index()
        {
            ExtNetModel model = new ExtNetModel()
            {
                Title = "Welcome to Ext.NET",
                TextAreaEmptyText = ">> Enter a Message Here <<"
            };

            return this.View(model);
        }

        public ActionResult SampleAction(string TextField3)
        {
            X.Msg.Notify(new NotificationConfig
            {
                Icon = Icon.Accept,
                Title = "Working",
               
            }).Show();

            return this.Direct();
        }
    }
}