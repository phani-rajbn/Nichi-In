using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMvcApp.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
      
    }
}