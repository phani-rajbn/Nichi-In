using System;
namespace SampleConApp
{
    enum DBSource { Memory, CSV, JSON, SQL, MySQL, Oracle, MongoDB }
    class DBComponent
    {
        public virtual void AddEmployee(int id, string name, string address)
        {
            Console.WriteLine($"Employee by ID {id} and name {name} added to memory");
        }
    }

    class DBFileComponent : DBComponent
    {
        public override void AddEmployee(int id, string name, string address)
        {
            Console.WriteLine($"Employee by ID {id} and name {name} added to CSV file");
        }
    }

    class DBJsonComponent : DBComponent
    {
        public override void AddEmployee(int id, string name, string address)
        {
            Console.WriteLine($"Employee by ID {id} and name {name} added to JSON file");
        }
    }

    class DBSqlServerComponent : DBComponent
    {
        public override void AddEmployee(int id, string name, string address)
        {
            Console.WriteLine($"Employee by ID {id} and name {name} added to the SQL server database");
        }
    }


    static class DBFactory
    {
        public static DBComponent CreateComponent(DBSource source)
        {
            DBComponent com = null;
            switch (source)
            {
                case DBSource.Memory:
                    com = new DBComponent();
                    break;
                case DBSource.CSV:
                    com = new DBFileComponent();
                    break;
                case DBSource.JSON:
                    com = new DBJsonComponent();
                    break;
                case DBSource.SQL:
                    com = new DBSqlServerComponent();
                    break;
                case DBSource.MySQL:
                case DBSource.Oracle:
                case DBSource.MongoDB:
                default:
                    com = new DBComponent();
                    break;
            }
            return com;
        }
    }
    class RPMain
    {
        static DBComponent com = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the type of source from the list below");
            Array sources = Enum.GetValues(typeof(DBSource));
            foreach (var source in sources) Console.WriteLine(source);
            DBSource selectedSource = (DBSource)Enum.Parse(typeof(DBSource), Console.ReadLine());
            com = DBFactory.CreateComponent(selectedSource);
            com.AddEmployee(123, "Phaniraj", "Bangalore");
        }
    }
}