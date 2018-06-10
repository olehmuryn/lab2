using MvcApplication1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request["txt"] != null)
            {
                if (Request["txt"][Request["txt"].Length - 1] == '+' || Request["txt"][Request["txt"].Length - 1] == '-' || Request["txt"][Request["txt"].Length - 1] == '*' || Request["txt"][Request["txt"].Length - 1] == '/')
                {
                    ViewBag.flag = 0;
                    ViewBag.result = Request["txt"];
                }
                else
                {
                    ViewBag.result =  Calculator.GetResult(Request["txt"]);
                    ViewBag.flag = 1;
                }
            }
            return View();
        }
    }
}
