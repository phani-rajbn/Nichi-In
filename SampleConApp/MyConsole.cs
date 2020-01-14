using System;
namespace SampleConApp {
    class MyConsole
    {
        public static string GetString(string question)
        {
            Console.WriteLine(question);
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

        public static DateTime GetDate(string question)
        {
            Console.WriteLine(question);
            DateTime dt = DateTime.Parse(Console.ReadLine());
            return dt;
        }
    }
}