using System;
namespace SampleConApp
{
    /// <summary>
    /// A Small Program to work on Data types and Operators along with Statements and Expressions.
    /// </summary>
    class CalcProgram
    {
        static bool processOperation(string menu)
        {
            string option = MyConsole.GetString(menu);
            switch (option)
            {
                case "1":
                    addingOperation();
                    return true;
                case "2":
                    subtractOperation();
                    return true;
                case "3":
                case "4":
                    return true;
                default:
                    return false;
            }
        }
        static void addingOperation()
        {
            double first = MyConsole.GetDouble("Enter First Value");
            double second = MyConsole.GetDouble("Enter the Second Value");
            Console.WriteLine("The Added value is " + (first + second));
            MyConsole.ClearScreen();
        }

        static void subtractOperation()
        {
            double first = MyConsole.GetDouble("Enter First Value");
            double second = MyConsole.GetDouble("Enter the Second Value");
            Console.WriteLine("The Subtracted value is " + (first + second));
            MyConsole.ClearScreen();
        }

        static string createMenu()
        {
            string menu = "Calc Program\nTo Add Numbers-------->Press 1\n";
            menu += "To Subtract Numbers------>Press 2\n";
            menu += "To Multiply Numbers------>Press 3\n";
            menu += "To Divide Numbers-------->Press 4\n";
            menu += "PS: Any other key is considered as EXIT\n";
            return menu;
        }
        static void Main(string[] args)
        {
            string menu = createMenu();
            bool processing = true;
            do
            {
                processing = processOperation(menu);
            } while (processing);
        }
    }

    class MyConsole
    {
        public static string GetString(string question)
        {
            Console.WriteLine(question.ToUpper());
            return Console.ReadLine();
        }
        public static double GetDouble(string question)
        {
            string answer = GetString(question);
            return double.Parse(answer);
        }

        public static int GetNumber(string question)
        {
            return int.Parse(GetString(question));
        }

        public static void ClearScreen()
        {
            Console.WriteLine("Press any key to clear");
            Console.ReadKey();
            Console.Clear();
        }
    }
}