using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMvcApp.Models;
namespace SampleMvcApp.Controllers
{
    public class FirstController : Controller
    {
       public string Welcome()
        {
            return "Hello ASP.NET MVC!!!!";
        }
        //ViewResult is a class that is derived from ActionResult which will be the result of an action method. ViewResult is used when UR action returns a View. 
        public ViewResult CurrentExpense()
        {
            var model = new Expense
            {
                ExpenseID = 111,
                Description = "FlipKart purchase",
                Amount = 1156
            };
            return View(model);
        }

    }
}