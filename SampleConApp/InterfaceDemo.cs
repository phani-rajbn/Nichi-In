namespace SampleConApp
{
    using System;
    interface IParty
    {
       void GetCake();
        void InviteFriends();
        void GetFood();
    }
    class BirthdayParty : IParty
    {
        public void GetCake()
        {
            Console.WriteLine("Cake ordered from Cake of the day");
        }

        public void GetFood()
        {
            Console.WriteLine("Veg Food prepared at home for the party");
        }

        public void InviteFriends()
        {
            Console.WriteLine("Friends are invited thro WhatsApp");
        }
    }
    interface IExample
    {
        void example();
    }
    interface ISimple
    {
        void simple();
    }
    //Multiple interface Inheritance
    class SimpleExample : IExample, ISimple
    {
        public void example()
        {
            Console.WriteLine("Example function");
        }
        public void simple()
        {
            Console.WriteLine("Simple function");
        }
    }

    interface IEmployee
    {
        void Create(int id, string name, string address);
    }

    interface ICustomer
    {
        void Create(int id, string name, string address);
    }

    class EmployeeCustomer : ICustomer, IEmployee
    {
        public void Create(int id, string name, string address)
        {
            Console.WriteLine("Customer and Employee details are filled");
        }

        void IEmployee.Create(int id, string name, string address)
        {
            Console.WriteLine($"Employee added to the database with name {name} and {address}");
        }

        void ICustomer.Create(int id, string name, string address)
        {
            Console.WriteLine($"Customer added to the database with name {name} and {address}");
        }
    }
    class MainProgram
    {
        //static IParty party = new BirthdayParty();
        static void Main(string[] args)
        {
            //party.InviteFriends();
            //party.GetFood();
            //party.GetCake();

            //multipleInterfaceExample();

            multipleInterfaceWithSameMethods();
        }

        private static void multipleInterfaceWithSameMethods()
        {
            ICustomer cst = new EmployeeCustomer();
            cst.Create(123, "Phaniraj", "Bangalore");

            IEmployee emp = new EmployeeCustomer();
            emp.Create(123, "Phaniraj", "Bangalore");

            EmployeeCustomer empCst = new EmployeeCustomer();
            empCst.Create(123, "Phaniraj", "Bangalore");
        }

        private static void multipleInterfaceExample()
        {
            IExample ex = new SimpleExample();
            ex.example();

            ISimple sim = new SimpleExample();
            sim.simple();
        }


    }
}