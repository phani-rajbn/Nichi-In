using System;

namespace SampleConApp
{
    delegate double MathOperation(double first, double second);

    class MathProgram
    {
        //This function calls another function that is passed as arg to it.
        public static void InvokeFunc(MathOperation operation)
        {
            if (operation == null) throw new Exception("Not a valid method");
            var first = MyConsole.GetDouble("Enter the First value");
            var second = MyConsole.GetDouble("Enter the Second value");
            var result = operation(first, second);
            Console.WriteLine("The result: " +result);
        }
    }
    class DelegateExample
    {
        static void Main(string[] args)
        {

            // MathOperation op = new MathOperation(addFunc); v1.0 and v1.1
            //op is an alias to the function called addFunc...
            //MathOperation op = divFunc;
            //var res = op(123, 234);
            //Console.WriteLine("The result of this operation:"  + res);
            //MathOperation2 op = ;
            MathProgram.InvokeFunc(addFunc);
        }

        static double addFunc(double first, double second)
        {
            return first + second;
        }

        static double divFunc(double first, double second)
        {
            return first / second;
        }
    }
}