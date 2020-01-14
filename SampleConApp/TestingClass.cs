
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    using DalLayer;
    class TestingClass
    {
        static void Main(string[] args)
        {
            //Entities.Employee emp = new Entities.Employee();
            //emp.DateOfBirth = DateTime.Parse("17/04/1998");
            //Console.WriteLine("The Age is " + emp.Age);

            EmployeeDatabase db = new EmployeeDatabase();
            Entities.Employee emp = new Entities.Employee { EmpID = 1, DateOfBirth = DateTime.Now.AddYears(-43), EmpAddress = "bangalore", EmpName = "Phaniraj" };

            db.AddNewEmployee(emp);
            emp = new Entities.Employee { EmpID = 2, DateOfBirth = DateTime.Now.AddYears(-40), EmpAddress = "Mysore", EmpName = "Sunder" };
            db.AddNewEmployee(emp);

            db.AddNewEmployee(new Entities.Employee { EmpID = 3, EmpAddress = "Mysore", DateOfBirth = DateTime.Now.AddMonths(-345), EmpName = "Gopal" });
            db.DeleteEmployee(1);
            Entities.Employee [] values = db.GetAllEmployees();
            foreach(var temp in values)
                Console.WriteLine(temp.EmpName);
        }
    }
}
