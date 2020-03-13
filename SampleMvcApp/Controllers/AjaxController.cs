using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMvcApp.Models;
namespace SampleMvcApp.Controllers
{
    public class AjaxController : Controller
    {
        public ViewResult Home()
        {
            return View();
        }

        public PartialViewResult ViewRecords()
        {
            var data = new MyDBEntities().ExpenseTables.ToList();
            return PartialView(data);
        }

        public PartialViewResult Find(string id)
        {
            var exId = int.Parse(id);
            var selected = new MyDBEntities().ExpenseTables.FirstOrDefault((e) => e.ExpenseID == exId);
            return PartialView(selected);
        }

        public ActionResult Update(ExpenseTable model)
        {
            var context = new MyDBEntities();
            var selected =context.ExpenseTables.FirstOrDefault((e) => e.ExpenseID == model.ExpenseID);
            selected.ExpenseDate = model.ExpenseDate;
            selected.Detail = model.Detail;
            selected.Amount = model.Amount;
            context.SaveChanges();
            return RedirectToAction("Home");
        }
    }
}