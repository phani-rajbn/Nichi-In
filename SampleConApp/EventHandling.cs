//One of the practical advantages of using delegates is Events. Events are actions performed on the object. All Events are instances of delegates. They are usually defined as public events and will have event handlers in the invoking classes. 
using System;
namespace SampleConApp
{
    interface ISqlDatabase
    {
        void AddNewEmployee(int id, string name, double salary);
        void DeleteEmployee(int id);
    }

    class SqlDBComponent : ISqlDatabase
    {
        public event Action<string> DataModified = null; 
        public void AddNewEmployee(int id, string name, double salary)
        {
            Console.WriteLine("Added to the SqlDatabase");
            DataModified("Inserted to the database");
        }

        public void DeleteEmployee(int id)
        {
            Console.WriteLine("Removed from the SqlDatabase");
            DataModified("Deleted from the database");
        }
    }

    class EventUIProgram
    {
        static SqlDBComponent db = new SqlDBComponent();
        static void Main()
        {
            db.DataModified += Db_DataModified;
            db.AddNewEmployee(123, "Phaniraj", 45000);
        }

        private static void Db_DataModified(string obj)
        {
            Console.WriteLine(obj);
        }
    }
}