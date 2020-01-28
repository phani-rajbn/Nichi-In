/*
 * What is a Constructor? Method used to inject the dependencies for a successfull object creation so that I could use it without additional functional calls. It is implicitly invoked when used with a new operator. Constructors can take arguements. Constructor with no args is called as Default constructor. When a constructor is provided with multiple parameters, then we call that constructor as overloaded constructor. 
 * Constructor is a method which has the same name as the class, it does not have any return types including void. Constructors can be static also. 
 * If U have static members in UR Class and U wish to set values to it, U could create static Constructors. Static Constructors are invoked once and only once during the execution of the program. They are the first set of constructors to be invoked. They cannot be parameterized. They dont have access specifiers. The static constructors cannot be explicitly invoked, as it is internally done by the CLR. U really dont know when exactly static constructors will be invoked during the flow of the Program. 
 */
using System;
namespace SampleConApp
{
    class Infotainment
    {
        public string Name { get; set; }
        public bool HasRadio { get; set; }
        public string Navigator { get; set; }
        public void Play()
        {
            Console.WriteLine("Playing the song using " + Name);
        }
    }
    class Car
    {
        static int number;
        static Car()
        {
            Console.WriteLine("Enter the no of UR Car");
            number = int.Parse(Console.ReadLine());
        }
        public Car()
        {
            InfoDetails = new Infotainment { HasRadio = true, Name = "Philips Infotainment", Navigator = "MapsOfIndia" };
        }
        public Car(Infotainment info)
        {
            this.InfoDetails = info;
        }
        public int RegNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public Infotainment InfoDetails { get; set; }//Association in OOP...
    }
    class ConstructorDemo
    {
        static void Main(string[] args)
        {
            Car car = new Car(new Infotainment { HasRadio = true, Name = "JBL System", Navigator = "Google Maps" });
            car.InfoDetails.Play();//null....
        }

    }
}