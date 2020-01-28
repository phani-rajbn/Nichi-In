using System;

/*
 * Collections are classes that allow to store data and retrieve the data in the precised format on a need basis. 
 * Generic Collections and Non-Generic Collections. 
 * Generic Collections was introduced in .NET 2.0.(2005)
 * All Collection Classes implement a set of interfaces on which certain common features and methods are obtained.
 * IEnumerable, IEnumerator, ICollection, IList, IDictionary, ISet.......
 * Generic collections are like Templates of C++. They are more type specific. 
 * Collection classes are designed to overcome the limitations of Arrays. 
 * Generic Collection Classes and its interfaces are defined under System.Collections.Generic
 * 
 * HashSet uses HashCode, a no that identifies an object. 
 * Find the hierarchy of List, hashSet , Dictionary and Queue. 
 * List the classes and interfaces. 
 * IEnumerable: This interface is the one that makes a basic collection. 
 * ICollection: With some extra methods to find and remove...
 * IList: Methods to perform listing operations(add, remove, insert, removeat)
 * ISet: Which implements HashSet Features
 * IDictionary: For key-value pairs....
 * IComparable and IComparer. For Comparing objects: Sorting....
 * Custom Collections using the interface: IEnumerable. 
 */
namespace SampleConApp
{
    using System.Collections.Generic;
    using System.Linq;
    class CollectionsDemo
    {
        static void Main(string[] args)
        {
            //ListExample();
            //HashSetExample();
            //HashSetExample2();
            //DictionaryExample();
            //QueueExample();
            //StackExample();
            //LinkedListExample();

        }

        private static void LinkedListExample()
        {

            //LinkedList is a collection of LinkedListNodes where each node refers to itself and links to Previous and Next.
            LinkedList<string> tollPlaza = new LinkedList<string>();
            tollPlaza.AddFirst("Peenya");
            tollPlaza.AddLast("Nelamangala");
            tollPlaza.AddLast("Tumkur");
            tollPlaza.AddLast("Sira");
            tollPlaza.AddFirst("Nice Road");
            tollPlaza.Remove("Nice Road");
            foreach (var loc in tollPlaza) Console.WriteLine(loc);
            
        }

        private static void StackExample()
        {
            Stack<string> pages = new Stack<string>();
            pages.Push("Home");
            pages.Push("Contacts");
            pages.Push("ThirdContact");
            pages.Push("8thContact");
            foreach (var page in pages) Console.WriteLine(page);
            Console.WriteLine("Removing " + pages.Pop()  );
            Console.WriteLine("Removing " + pages.Pop());
            Console.WriteLine("After moving back 2 times...");
            foreach (var page in pages) Console.WriteLine(page);
        }

        private static void QueueExample()
        {
            Queue<string> recentList = new Queue<string>();
            do
            {
                if (recentList.Count == 5) recentList.Dequeue();
                string item = MyConsole.GetString("Enter the Item to see");
                recentList.Enqueue(item);
                MyConsole.ClearScreen();
                var it = recentList.Reverse();//System.Linq
                foreach (var i in it) Console.WriteLine(i);
            } while (true);
        }

        private static string createMenu()
        {
            string menu = $"Press 1 to Login\nPress 2 to Register\n";
            return menu;
        }
        private static void DictionaryExample()
        {
            //Storing the data in the form key-value pairs. Key is unique for the collection, value can be same. U refer the elements of the collection using key [key]. 
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("Admin", "admin123");
            users.Add("Clerk", "clerk123");
            Console.WriteLine("Iterating thro the complete collection....");
            foreach(var pair in users)
            {
                Console.WriteLine($"Key:{pair.Key}\tValue:{pair.Value}");
            }
            Console.WriteLine("Iterating only the keys....");
            foreach (var key in users.Keys) Console.WriteLine(users[key]);
            var menu = createMenu();

            do
            {
                RETRY:
                string choice = MyConsole.GetString(menu);
                if(choice == "1")
                {
                    string uName = MyConsole.GetString("Enter the User name to Login");
                    string pwd = MyConsole.GetString("Enter the Password to Login");
                    if (users.ContainsKey(uName))
                    {
                        if (users[uName] == pwd)
                            Console.WriteLine("Welcome User " + uName);
                        else
                        {
                            Console.WriteLine("Invalid Password...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Username is invalid..");
                    }
                }
                else
                {
                    RECAP:
                    string uName = MyConsole.GetString("Enter the User name U use to login");
                    string pwd = MyConsole.GetString("Enter the Password");
                    string retype = MyConsole.GetString("Retype the password");
                    if(retype != pwd)
                    {
                        Console.WriteLine("Password mismatch!!!");
                        goto RECAP;
                    }
                    if (users.ContainsKey(uName))
                    {
                        Console.WriteLine("User already Exists");
                        goto RETRY;
                    }
                    users[uName] = pwd;//add the new key-pair to the Dictionary. If the key exists it replaces the value.
                    Console.WriteLine("User registered to the database");
                }
            } while (true);

        }

        private static void HashSetExample2()
        {
            //Reference types equivalance is based on address...
            HashSet<Employee> employees = new HashSet<Employee>();
            employees.Add(new Employee { EmpID = 1, EmpName = "Joy", EmpAddress = "BLR", EmpSalary = 5600 });
            employees.Add(new Employee { EmpID = 2, EmpName = "Ram", EmpAddress = "MYS", EmpSalary = 4600 });
            employees.Add(new Employee { EmpID = 3, EmpName = "Tom", EmpAddress = "CHE", EmpSalary = 4600 });
            employees.Add(new Employee { EmpID = 4, EmpName = "Ali", EmpAddress = "HYD", EmpSalary = 3600 });

            employees.Add(new Employee { EmpID = 1, EmpName = "Joy", EmpAddress = "BLR", EmpSalary = 5600 });
            employees.Add(new Employee { EmpID = 2, EmpName = "Ram", EmpAddress = "MYS", EmpSalary = 4600 });
            employees.Add(new Employee { EmpID = 3, EmpName = "Tom", EmpAddress = "CHE", EmpSalary = 4600 });
            employees.Add(new Employee { EmpID = 4, EmpName = "Ali", EmpAddress = "HYD", EmpSalary = 3600 });
            Console.WriteLine($"The no of employees: {employees.Count}");
            foreach (var emo in employees) Console.WriteLine(emo.GetHashCode());
        }

        private static void HashSetExample()
        {
            //Similar to List, but stores only unique items in the collection, U can insert, delete anywhere within the collection.
            HashSet<string> basket = new HashSet<string>();
            do
            {
                string itemToAdd = MyConsole.GetString("Enter the fruit to add to the basket");
                var res = basket.Add(itemToAdd);
                if (!res) Console.WriteLine("Item already exists"); 
                MyConsole.ClearScreen();
                foreach (var item in basket) Console.WriteLine(item);                
            } while (true);
        }

        private static void ListExample()
        {
            List<string> fruits = new List<string>();//0 is the size.....
            fruits.Add("Apples");//Adds the item to the bottom of the list....
            fruits.Add("Mangos");
            fruits.Add("Oranges");
            fruits.Add("PineApples");
            fruits.Add("Bananas");
            if (fruits.Remove("PineApple"))
                Console.WriteLine("Deleted");
            else
                Console.WriteLine("Not there to delete");
            Console.WriteLine("The no of items with us is " + fruits.Count);
            foreach (var fruit in fruits) Console.WriteLine(fruit);
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}
