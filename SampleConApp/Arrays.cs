using System;

namespace SampleConApp
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //differentSyntaxesOfArray();
            //multiDimensionalArray();
            //jaggedArrayExample();
            //Shopping App:
            //Each Person name and his purchases.
            //StringbasedJaggedArray();
            dynamicArrayExample();

        }

        private static void dynamicArrayExample()
        {
            //size, type, values to fill, reading the data...
            int size = MyConsole.GetNumber("Enter the size of the array");
            string type = MyConsole.GetString("Enter the data type as CTS Type");
            Type dataType = Type.GetType(type);
            Array array = Array.CreateInstance(dataType, size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the value of the type " + dataType.Name);
                object value = Convert.ChangeType(Console.ReadLine(), dataType);
                array.SetValue(value, i);
            }
            Console.WriteLine("All the values are set, please press any key to view the data");
            Console.ReadKey();
            foreach (object value in array) Console.WriteLine(value);

        }

        private static void StringbasedJaggedArray()
        {
            string[][] shopping = new string[6][];
            for (int i = 0; i < shopping.Length; i++)
            {
                int size = MyConsole.GetNumber($"Enter the no of Items purchased by Guy {i}");
                shopping[i] = new string[size];
                Console.WriteLine($"Enter the products purchased by string {i}");
                for (int j = 0; j < size; j++)
                {
                    shopping[i][j] = MyConsole.GetString("Enter the Product name");
                }
                Console.WriteLine("Thanks for shopping with Us!!!!");
            }
            for (int i = 0; i < shopping.Length; i++)
            {
                foreach (string item in shopping[i])
                    Console.WriteLine(item);
                Console.Write("\n\n\n");
            }
        }

        private static void jaggedArrayExample()
        {
            int[][] school = new int[4][];//No of Classrooms....
            school[0] = new int[] { 34, 45, 56, 67, 78 };
            school[1] = new int[] { 67, 56, 66, 55, 44, 66, 78, 89 };
            school[2] = new int[] { 54, 45, 55, 22, 45, 67, 88, 98, 77, 56, 67, 78 };
            school[3] = new int[] { 67, 23, 56, 66, 55, 44, 66, 78, 89 };

            for (int i = 0; i < school.Length; i++)//No of Rows...
            {
                foreach(int score in school[i])
                    Console.Write(score + " ");
                Console.WriteLine();
            }

        }

        private static void multiDimensionalArray()
        {
            int[,] TwoDArray = new int[5, 4];
            for (int i = 0; i < TwoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDArray.GetLength(1); j++)
                {
                    TwoDArray[i, j] = MyConsole.GetNumber($"Enter the value at position {i},{j}");
                }
            }
            for (int i = 0; i < TwoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDArray.GetLength(1); j++)
                {
                    Console.Write(TwoDArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void differentSyntaxesOfArray()
        {
            simpleArrayExample();
            anotherSyntax();
            newSyntax();
        }

        private static void newSyntax()//C# 4.0
        {
            int[] data = { 234, 3345, 345, 334, 345, 35, 3434, 53, 3, 534, 34, 5, 35345 };
        }

        private static void anotherSyntax()
        {
            int size = MyConsole.GetNumber("How many fruits U want to add to the basket");
            string[] basket = new string[size];
            for (int i = 0; i < basket.Length; i++)
            {
                basket[i] =MyConsole.GetString($"Enter the fruit name to add to location {i}");
            }
            foreach (string item in basket) Console.WriteLine(item);
        }

        private static void simpleArrayExample()
        {
            string[] fruits = new string[]
            {
                "Apple","Mango", "Orange","PineApple","Banana"
            };
            Console.WriteLine("The no of elements in the Array is " + fruits.Length);
            Console.WriteLine("The No of Dimensions of this Array is " + fruits.Rank);
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            foreach (string fruit in fruits) Console.WriteLine(fruit);//foreach is a convinient way of iterating a group of data without knowing its size. It will always remain within the bounds of the collection. foreach is always forward only and read only. 
        }
    }
}
