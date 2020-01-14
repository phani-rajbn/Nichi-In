using System;
namespace Entities
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get {
                return calculateAge();
            }
        }
        private int calculateAge()
        {
            TimeSpan span = DateTime.Now - DateOfBirth;
            //Subtract current date with Date of birth...
            //Timespan to find no of Years
            int years = (int)(span.Days / 365.25);
            return years;
        }
    }
}

namespace DalLayer
{
    using Entities;
    class EmployeeDatabase
    {
        private Employee[] _data = new Employee[100];
        //U cannot increase or decrease the size of the Array.
        public void AddNewEmployee(Employee emp)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i] == null)
                {
                    //_data[i] = emp;
                    _data[i] = new Employee();
                    _data[i].EmpID = emp.EmpID;
                    _data[i].EmpName = emp.EmpName;
                    _data[i].EmpAddress = emp.EmpAddress;
                    _data[i].DateOfBirth = emp.DateOfBirth;
                    return;
                }
            }
            throw new Exception("Employee cannot be added to the database");
        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if((_data[i] != null) && (_data[i].EmpID == id))
                {
                    _data[i] = null;
                    return;

                }
            }
            throw new Exception($"Employee by ID {id} not found to delete");
        }

        public void UpdateEmployee(Employee emp)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if((_data[i] != null)&&(_data[i].EmpID == emp.EmpID))
                {
                    _data[i].EmpName = emp.EmpName;
                    _data[i].EmpAddress = emp.EmpAddress;
                    _data[i].DateOfBirth = emp.DateOfBirth;
                    return;
                }
            }
            throw new Exception("Employee not found to update");
        }

        public Employee[] GetAllEmployees()
        {
            Employee[] _copy = new Employee[0];//Create a blank Array...
            for (int i = 0; i < _data.Length; i++)
            {
                if(_data[i] != null)
                {
                    Array clone = _copy.Clone() as Array;//create a temp copy...
                    _copy = new Employee[clone.Length + 1];
                    clone.CopyTo(_copy, 0);
                    _copy[_copy.Length - 1] = _data[i];
                }
            }
            return _copy;//Copy contains only valid Employee records, no nulls....
        }
    }
}

namespace Common
{
    using System.IO;
    class Utility
    {
        public static string CreateMenu()
        {
            string menu = File.ReadAllText(@"B:\Programs\NichiIn-2020\Nichi-InTraining\SampleConApp\Menu.txt");
            return menu;
        }
    }
}

namespace UILayer
{
    using Common;
    using SampleConApp;
    using DalLayer;
    class MainClass
    {
        static EmployeeDatabase db = new EmployeeDatabase();
        static void Main(string[] args)
        {
            string menu = Utility.CreateMenu();
            bool processing = true;
            do
            {
                string choice = MyConsole.GetString(menu);
                processing = processMenu(choice);
                MyConsole.ClearScreen();
            } while (processing);
        }

        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    addingEmployee();
                    return true;
                    
                case "2":
                    updatingEmployee();
                    return true;
                case "3":
                case "4":
                    return true;
                default:
                    return false ;
            }
        }

        private static void updatingEmployee()
        {
        RETRY:
           try 
            {
                var id = MyConsole.GetNumber("Enter the ID of the Employee to update");
                var name = MyConsole.GetString("Enter the Name to Update");
                var address = MyConsole.GetString("Enter the Address to Update");
                var dob = MyConsole.GetDate("Enter the date of Birth tp Update as dd/MM/yyyy");
                var emp = new Entities.Employee
                {
                    DateOfBirth = dob,
                    EmpAddress = address,
                    EmpID = id,
                    EmpName = name
                };
                db.UpdateEmployee(emp);
                Console.WriteLine("Employee updated successfully to the database");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid Entry\nPlease try again");
                goto RETRY;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto RETRY;
            }
        }

        private static void addingEmployee()
        {
            /*
             * take inputs from the user
             * create the Employee object and fill data into it.
             * call the addEmployee function of the db object and pass the employee object into it
             * handle any exceptions...
             */
             RETRY:
            try
            {
                var id = MyConsole.GetNumber("Enter the ID of the Employee to add");
                var name = MyConsole.GetString("Enter the Name");
                var address = MyConsole.GetString("Enter the Address");
                var dob = MyConsole.GetDate("Enter the date of Birth as dd/MM/yyyy");
                var emp = new Entities.Employee
                {
                    DateOfBirth = dob,
                    EmpAddress = address,
                    EmpID = id,
                    EmpName = name
                };
                db.AddNewEmployee(emp);
                Console.WriteLine("Employee added successfully to the database");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid Entry\nPlease try again");
                goto RETRY;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto RETRY;
            }
        }
    }
}