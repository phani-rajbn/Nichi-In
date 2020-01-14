using System;

/*
 * Class is the fundamental unit of any OOP language. 
 * Class is a User defined type that will represent a real world entity. 
 * A class can have both data as well as functions to operate on that data. 
 * Data will be usually private or hidden to the outside world(Outside the class).
 * The other units of the App will interact with the data only thro the functions. 
 * In C#, a class can contain fields, properties, functions, events and even nested classes. 
 */
namespace SampleConApp
{
    class Employee
    {
        public string name, address;
        public DateTime dateOfbirth;
        public double salary;
        //When the keyword public is used, it makes the members accessible from anywhere within the Application. If U don't mention the public, it is available only within the class. It is called as private accessor.
    }
    class EntityClasses
    {
        static void Main(string[] args)
        {
            //The Class is more like a prototype. The variable of the class that u create is called as Instance of the class or simply the object of the class. using the object we access the members of the class using . operator. objects in C# are created only in the heap. U cannot create objects of a class inside the stack...

            Employee emp = new Employee();//new operator is must for object creation in C#...
            emp.name = MyConsole.GetString("Enter the Name");
            emp.address = MyConsole.GetString("Enter the Address");
            //emp.dateOfbirth = MyConsole.GetDate("Enter the date of birth in the format of dd/MM/yyyy");
            //emp.salary = MyConsole.GetDouble("Enter the salary");

            Console.WriteLine("The name of the Employee is {" +emp.name + "} from {" +  emp.address +"}");


        }
    }
}
