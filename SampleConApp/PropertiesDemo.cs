using System;
//Data(Fields) inside the class is usually private. Private is the default access specifier in C#. 
//To Access the private fields, C# gives Properties: Getters and Setters are accessors to the private data. 
//Internally, properties behave like functions and are used like Fields. 

namespace SampleConApp
{
    class NichiEmployee
    {
        string name, address;
        public DateTime dateOfbirth;
        double salary;
        //When the keyword public is used, it makes the members accessible from anywhere within the Application. If U don't mention the public, it is available only within the class. It is called as private accessor.

        public string EmployeeName
        {
            get { return name; }
            set { name = value; }
        }

        public string EmployeeAddress
        {
            get { return address; }
            set { address = value; }
        }

        public double EmployeeSalary
        {
            get { return salary; }
            set { salary = value; }
        }
        //create the property of DateOfBirth also...
    }
    class PropertiesDemo
    {
        static Employee temp = new Employee();
        static void Main(string[] args)
        {
            NichiEmployee emp = new NichiEmployee();
            emp.EmployeeName = "Phaniraj";
            emp.EmployeeAddress = "Bangalore";
            emp.EmployeeSalary = 56000;
            emp.dateOfbirth = DateTime.Parse("12/12/2010");
            Console.WriteLine($"The Name is {emp.EmployeeName} from {emp.EmployeeAddress}");
            Console.WriteLine("The Date of birth is " + emp.dateOfbirth.ToShortDateString());
        }
    }
}
