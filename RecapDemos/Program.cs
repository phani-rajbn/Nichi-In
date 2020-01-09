using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemos
{
    class Program
    {
        static void hellowWorld(string arg)
        {
            Console.WriteLine(arg);
        }
        static void Main(string[] args)
        {
            //assignment1();
            //assignment2();
            //assignment3();
            assignment4();
            //assignment5();    
        }

        private static void assignment5()
        {
            //THe Function takes an Array of integers which should display the sum of odd and Even numbers.
        }

        private static void assignment4()
        {
            //Implement a function that prints a Calendar of a given month. The function takes Month and Year as arg which should print the month's calendar. 
            printCalendar(8, 2019);
        }

        private static void printCalendar(uint month, uint year)
        {
            
        }

        private static void assignment3()
        {
            //The function should validate a given date. It takes 3 args:year, month day. The function should return true if its a valid date else false.
            //year=2019, month = 23, day = 1: false...
            //year=2018, month = 2, day = 29: false...
            //It should not use any Predefined Functions. U can create subfunctions to make it modular. 
            if (validateDate(2010, 0, 31))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

        }

        private static bool validateDate(uint year, uint month, uint day)
        {
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if(IsLeapYear(year)) months[1] = 29;
            if ((month == 0) || (year ==0) || (day ==0)) return false;
            month = month - 1;//Index Starts with 0...
            if (day > months[month])
                return false;
            if (month > 12)
                return false;
            return true;
        }

        private static bool IsLeapYear(uint year)
        {
            if ((year % 4 == 0) && (year % 100 !=0))
                return true;
            else
                return false;
        }

        /// <summary>
        /// BMI Calculator program.
        /// </summary>
        private static void assignment2()
        {
            //Take the inputs from the user. 
            Console.WriteLine("Enter the weight in Kgs");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height in Feet");
            double feet = double.Parse(Console.ReadLine());
            double height = ConvertToMeter(feet);
            //Pass the inputs to the GetBMI Function and get the result
            double bmi = GetBMI(weight, height);
            //Display the result...
            Console.WriteLine("The BMI of this person is {0:##.##}" , bmi);
        }
        private static double ConvertToMeter(double feet)
        {
            return feet / 3.28;
        }
        private static double GetBMI(double weight, double height)
        {
            //Formula: weight/height^2
            double bmi = weight / (height * height);
            return bmi;
        }

        
        private static void assignment1()
        {
            Console.WriteLine("Enter the value");
            string value = Console.ReadLine();
            hellowWorld(value);
        }
    }
}
