using System;
using System.Collections.Generic;
using System.Data;
using EntitiesLib;
using System.IO;
using System.Xml.Serialization;
namespace SampleDllLib
{
    class SerializationComponent : IEmpDatabase
    {
        List<Employee> _employees = new List<Employee>();
        const string fileName = "Employees.xml";
        private void saveToDisc()
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sm = new XmlSerializer(typeof(List<Employee>));
            sm.Serialize(fs, _employees);
            fs.Close();
        }

        private void loadFromDisc()
        {
            if (!File.Exists(fileName))
            {
                _employees = new List<Employee>();
                return;
            }
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            XmlSerializer sm = new XmlSerializer(typeof(List<Employee>));
            _employees = sm.Deserialize(fs) as List<Employee>;
            fs.Close();
        }
        public void AddNewEmployee(int id, string name, string address, double salary)
        {
            loadFromDisc();
            Employee emp = new Employee { EmpID = id, EmpAddress = address, EmpName = name, EmpSalary = salary };
            _employees.Add(emp);
            saveToDisc();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllEmployees()
        {
            loadFromDisc();
            DataTable table = new DataTable("Employees");
            table.Columns.Add("EmpID", typeof(int));
            table.Columns.Add("EmpName", typeof(string));
            table.Columns.Add("EmpAddress", typeof(string));
            table.Columns.Add("EmpSalary", typeof(double));
            table.AcceptChanges();
            foreach(var emp in _employees)
            {
                DataRow row = table.NewRow();
                row[0] = emp.EmpID;
                row[1] = emp.EmpName;
                row[2] = emp.EmpAddress;
                row[3] = emp.EmpSalary;
                table.Rows.Add(row);
            }
            table.AcceptChanges();
            return table;
        }

        public void UpdateEmployee(int id, string name, string address, double salary)
        {
            loadFromDisc();//load existing data thro Deserialization
            var rec = _employees.Find((e) => e.EmpID == id);//find the matching record
            if (rec == null) throw new Exception("Employee not found to update");//Not found throw an Exception
            rec.EmpName = name;//Set the new values..
            rec.EmpAddress = address;
            rec.EmpSalary = salary;
            saveToDisc();//save to serialization...
        }
    }
}
