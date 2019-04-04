using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace jenkinsnunittestweb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.data= System.Configuration.ConfigurationManager.AppSettings["Environment"];
            return View();
        }
        public ActionResult add()
        {
            string a = Request.Form["1st number"];
            int n1 = Convert.ToInt32(a);
            string b = Request.Form["2nd number"];
            int n2 = Convert.ToInt32(b);
            sumkolaagi s = new sumkolaagi();
            int result=s.summethod(n1, n2);
            ViewBag.result = result;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}