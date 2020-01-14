using System;
//Example on Type Conversions.
//use Ctrl+H to Find and Replace....
namespace SampleConApp
{
    class TypeConversions
    {
        static void Main(string[] args)
        {
            //displayRanges();
            //simpleConversionDemo();
            //floatingExample();
            //convertingToObject();
            string value = MyConsole.GetString("Enter the type of the variable U want to create\nint, String, double or bool");
            object result = createVariable(value);
            if(result.GetType().Name == "String")
                Console.WriteLine(result.ToString().ToUpper());
            else
            {
                Console.WriteLine((int)result);
            }
        }

        private static object createVariable(string type)
        {
            object value;
            if (type == "int")
                value = 123;
            else if (type == "String")
                value = "Apple123";
            else if (type == "double")
                value = 134.23455;
            else
                value = true;
            return value;
        }
        private static void convertingToObject()
        {
            //Any type can be implicitly converted to object type. This is called as BOXING.  Internally the object will hide the features of the data type of the data that the object holds. Hense its called as BOXING. 
            object data = 123;//int is stored as object. This is BOXING....
            //For any operations related to the data type, U should again type cast it to its type and then do the operation.
            int value = (int)data;//UNBOXING is a feature where the object type will be converted to the internal type of the data it holds. The object can be unboxed to the same type from which it was boxed....
            value++;
            data = value;//BOXING...
        }

        private static void floatingExample()
        {
            float no = 234.845F;//Use the F letter to make the variable as float....
            int iNo = (int)no;
            Console.WriteLine($"{iNo} as int and {no} as float");
        }

        /// <summary>
        /// This function is to show how C Style and Convert class works. 
        /// Check for Arithematic Overflow to see the Exception during Convert class methods usage. 
        /// </summary>
        private static void simpleConversionDemo()
        {
            int value = 123;
            long lValue = int.MaxValue + value;//int is shorter than long....
            Console.WriteLine(lValue);
            //value = (int)lValue;//C Style Casting will not raise any exception if the range is not met....
            value = Convert.ToInt32(lValue);//Will raise an Exception. Use this for conversions instead of C Style Casting....
            Console.WriteLine("The Value" + value);
        }
        /// <summary>
        /// This function is to demonstrate the ranges of all numeric types of .NET
        /// </summary>
        private static void displayRanges()
        {
            Console.WriteLine($"The Range of byte is {byte.MinValue} and {byte.MaxValue}");
            Console.WriteLine($"The Range of short is {short.MinValue} and {short.MaxValue}");
            Console.WriteLine($"The Range of int is {int.MinValue} and {int.MaxValue}");
            Console.WriteLine($"The Range of long is {long.MinValue} and {long.MaxValue}");
            Console.WriteLine($"The Range of float is {float.MinValue} and {float.MaxValue}");
            Console.WriteLine($"The Range of double is {double.MinValue} and {double.MaxValue}");
            Console.WriteLine($"The Range of decimal is {decimal.MinValue} and {decimal.MaxValue}");
        }
    }
}
