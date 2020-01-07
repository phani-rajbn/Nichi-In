//InputOutput.cs
using System;
using SampleConApp;
namespace Basics{
	class SimpleIO 
	{
	  static void Main(){
	  	//basicPrinting();
	  	takingInputsExample();
	  }	

	  static void takingInputsExample(){
	  string name = MyConsole.GetString("Enter the Name");
	  
	  	Console.WriteLine("Enter the Age as Number");
	  	int age = int.Parse(Console.ReadLine());

	  	Console.WriteLine("Enter the Salary");
	  	double salary = double.Parse(Console.ReadLine());
	  	//Most of the data types have functions to convert a string to its own type...
	  	Console.WriteLine("Now lets display the data entered by the user");
	  	Console.WriteLine("The Name entered is {0}\nMr.{0}'s' Age is {1} and earns a salary of {2:C}", name, age, salary);
	  }
	  //Any group of statements can be created as a Function and U can call the function from the Main....
	  static void basicPrinting(){
	  	Console.WriteLine("Testing 123");
	  	Console.Write("It writes on the Console and remains in the same line");
	  	Console.WriteLine(" Write the text and move the carrier return to the next line");
	  }
	}
}