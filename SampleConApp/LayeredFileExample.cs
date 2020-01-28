using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
namespace SampleConApp
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }
    }

    interface IEmpDatabase
    {
        void AddNewEmployee(int id, string name, string address, double salary);
        void UpdateEmployee(int id, string name, string address, double salary);
        void DeleteEmployee(int id);
        DataTable GetAllEmployees();
    }

    interface IEmpBO
    {
        void AddNewEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int id);
        List<Employee> GetAllEmployees();
    }

    class EmpFileDB : IEmpDatabase
    {
        const string filename = "SampleData.csv";
        static DataTable table = new DataTable("Employees");
        public EmpFileDB()
        {
            table.Columns.Add("EmpID", typeof(int));
            table.Columns.Add("EmpName", typeof(string));
            table.Columns.Add("EmpAddress", typeof(string));
            table.Columns.Add("EmpSalary", typeof(double));
            table.AcceptChanges();
        }
        public void AddNewEmployee(int id, string name, string address, double salary)
        {
            string line = $"{id},{name},{address},{salary}\n";
            File.AppendAllText(filename, line);
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllEmployees()
        {
            table.Rows.Clear();//It removes all the existing dasta in the table
            table.AcceptChanges();//save it...
            var lines = File.ReadAllLines(filename);
            foreach(var line in lines)
            {
                var words = line.Split(',');
                DataRow row = table.NewRow();
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    row[i] = words[i];
                }
                table.Rows.Add(row);
            }
            return table;
        }

        public void UpdateEmployee(int id, string name, string address, double salary)
        {
            throw new NotImplementedException();
        }
    }

    class EmpBOComponent : IEmpBO
    {
        static IEmpDatabase db = new EmpFileDB();
        public void AddNewEmployee(Employee emp)
        {
            db.AddNewEmployee(emp.EmpID, emp.EmpName, emp.EmpAddress, emp.EmpSalary);
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            //create a blank list of Employees
            List<Employee> employees = new List<Employee>();
            //call the Dal Component's GetAllEmployees
            var table = db.GetAllEmployees();
            //iterate thro the rows to fill the emp objects
            foreach(DataRow row in table.Rows)
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
            throw new NotImplementedException();
        }
    }

    class UITester
    {
        static void Main(string[] args)
        {
            IEmpBO db = new EmpBOComponent();
            var records = db.GetAllEmployees();
            foreach (var emp in records) Console.WriteLine(emp.EmpName);
            //db.AddNewEmployee(new Employee { EmpID = 1002, EmpName = "Gopal", EmpSalary = 45000, EmpAddress = "Pune" });
        }
    }
}