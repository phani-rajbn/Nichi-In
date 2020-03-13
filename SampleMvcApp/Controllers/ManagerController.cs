using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMvcApp.Models;
namespace SampleMvcApp.Controllers
{
    public class ManagerController : Controller
    {
        static MyDBEntities context = new MyDBEntities();
       public ActionResult ShowAll()
        {
            var model = context.ExpenseTables.ToList();
            return View(model);
        }
        //This id is the route value.....
        public ActionResult Find(string id)
        {
            var exId = int.Parse(id);
            var expense = context.ExpenseTables.FirstOrDefault((e) => e.ExpenseID == exId);
            if (expense == null) throw new Exception("Expense not found");
            return View(expense);
        }

        public ActionResult Update(ExpenseTable model)
        {
            var selected = context.ExpenseTables.FirstOrDefault((e) => e.ExpenseID == model.ExpenseID);
            selected.ExpenseDate = model.ExpenseDate;
            selected.Detail = model.Detail;
            selected.Amount = model.Amount;
            context.SaveChanges();
            return RedirectToAction("ShowAll");
        }
        [HttpGet]
        public ViewResult AddNew()
        {
            return View();//Create a blank Expense object and send it to the View....

        }
        [HttpPost]
        public ActionResult AddNew(FormCollection form)//Another way to send the data from the View to the Controller...
        {
            var details = form["desc"];
            var amount = int.Parse(form["amount"]);
            var date = DateTime.Parse(form["date"]);
            var row = new ExpenseTable
            {
                Amount = amount,
                Detail = details,
                ExpenseDate = date
            };
            context.ExpenseTables.Add(row);
            context.SaveChanges();
            return RedirectToAction("ShowAll");
        }
    }
}