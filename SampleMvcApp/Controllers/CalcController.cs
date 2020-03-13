using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcApp.Controllers
{
    public class CalcController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Options = new List<SelectListItem> {
                new SelectListItem { Text = "Add" },
                new SelectListItem { Text = "Subtract" },
                new SelectListItem { Text = "Multiply" },
                new SelectListItem { Text = "Divide" }
            };
            return View();
        }

        //parameters should be same as the expression names given in the form.
        public ActionResult Onpost(double FirstValue, double SecondValue, string Option)
        {
            var result = 0.0;
            switch (Option)
            {
                case "Add":
                    result = FirstValue + SecondValue;
                    break;
                case "Subtract":
                    result = FirstValue - SecondValue;
                    break;
                default:
                    result = FirstValue * SecondValue;
                    break;
            }
            TempData["Result"] = result;
            TempData["MyFruit"] = "Mango";
            TempData["MyAddress"] = "Bangalore";
            TempData.Keep();//It retains all the values of one action into another..
            return RedirectToAction("Index");
        }
    }
}