using EntitiesLib;
using SampleDllLib;
using System;
using System.Collections.Generic;
using System.Data;

namespace EmployeeBOLib
{
    public interface IEmpBO
    {
        void AddNewEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int id);
        List<Employee> GetAllEmployees();
    }

    public class EmpBOComponent : IEmpBO
    {
        static IEmpDatabase db = DataFactory.GetComponent();
        public void AddNewEmployee(Employee emp)
        {
            db.AddNewEmployee(emp.EmpID, emp.EmpName, emp.EmpAddress, emp.EmpSalary);
        }


        public void DeleteEmployee(int id)
        {
            db.DeleteEmployee(id);
        }

        public List<Employee> GetAllEmployees()
        {
            //create a blank list of Employees
            List<Employee> employees = new List<Employee>();
            //call the Dal Component's GetAllEmployees
            var table = db.GetAllEmployees();
            //iterate thro the rows to fill the emp objects
            foreach (DataRow row in table.Rows)
            {
                var emp = new Employee();
                emp.EmpID = Convert.ToInt32(row[0]);
                emp.EmpName = row[1].ToString();
                emp.EmpAddress = row[2].ToString();
                emp.EmpSalary = Convert.ToDouble(row[3]);
                employees.Add(emp);
            }
            //return the list...
            return employees;
        }

        public void UpdateEmployee(Employee emp)
        {
            db.UpdateEmployee(emp.EmpID, emp.EmpName, emp.EmpAddress, emp.EmpSalary);
        }
    }
}
