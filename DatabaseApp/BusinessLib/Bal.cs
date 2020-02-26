using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLib;
using EntitiesLib;
using System.Data;
namespace BusinessLib
{
    public interface IEmployeeComponent
    {
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        List<Employee> GetAllEmployees();
    }

    public class EmployeeFactory
    {
        public static IEmployeeComponent GetComponent()
        {
            return new EmployeeComponent();
        }
    }

    class EmployeeComponent : IEmployeeComponent
    {
        static IDataComponent component = DataFactory.CreateComponent();
        public void AddEmployee(Employee employee)
        {
            component.AddEmployee(employee.EmpID, employee.EmpName, employee.EmpAddress, employee.EmpSalary);
        }

        public void DeleteEmployee(int id)
        {
            try
            {
                component.DeleteEmployee(id);
            }
            catch (Exception)
            {
                throw new Exception("Deletion failed!!!");
            }
        }

        public List<Employee> GetAllEmployees()
        {
            if (component == null)
                throw new Exception("Dal Layer is not implemented");
            var table = component.GetAllEmployees();
            var list = new List<Employee>();
            foreach(DataRow row in table.Rows)
            {
                var emp = new Employee
                {
                    EmpID = Convert.ToInt32(row[0]),
                    EmpName = row[1].ToString(),
                    EmpAddress =row[2].ToString(),
                    EmpSalary = Convert.ToDouble(row[3])
                };
                list.Add(emp);
            }
            return list;
        }

        public void UpdateEmployee(Employee e)
        {
            try
            {
                component.UpdateEmployee(e.EmpID, e.EmpName, e.EmpAddress, e.EmpSalary);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
