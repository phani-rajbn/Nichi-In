using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Configuration;
using System;

namespace SampleDllLib
{
    public interface IEmpDatabase
    {
        void AddNewEmployee(int id, string name, string address, double salary);
        void UpdateEmployee(int id, string name, string address, double salary);
        void DeleteEmployee(int id);
        DataTable GetAllEmployees();
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
            GetAllEmployees();//To get the fresh data...
            foreach (DataRow row in table.Rows)
            {
                if (row[0].ToString() == id.ToString())
                {
                    row.Delete();
                    table.AcceptChanges();
                    break;
                }
            }
            saveRecords();//This will overwrite the file with new data....
        }

        private void saveRecords()
        {
            List<string> lines = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                var line = $"{row[0]},{row[1]},{row[2]},{row[3]}";
                lines.Add(line);
            }
            File.WriteAllLines(filename, lines);
        }

        public DataTable GetAllEmployees()
        {
            table.Rows.Clear();//It removes all the existing dasta in the table
            table.AcceptChanges();//save it...
            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
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
            GetAllEmployees();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow r = table.Rows[i];
                if (r[0].ToString() == id.ToString())
                {
                    r[1] = name;
                    r[2] = address;
                    r[3] = salary;
                    table.AcceptChanges();
                    break;
                }
            }
            saveRecords();
        }
    }

    public class DataFactory
    {
        public static IEmpDatabase GetComponent()
        {
            //string classname = ConfigurationManager.AppSettings["DalComponent"];
            //var component = Activator.CreateInstance(Type.GetType(classname));
            //return component as IEmpDatabase;
            return new SerializationComponent();
        }
    }
}
