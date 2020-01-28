using System;
namespace SampleConApp
{

    class EmployeeNotFoundException : ApplicationException
    {
        public EmployeeNotFoundException() { }
        public EmployeeNotFoundException(string message) : base(message) { }
        public EmployeeNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
    class InsertionFailedException : ApplicationException
    {
        public InsertionFailedException() { }
        public InsertionFailedException(string message) : base(message) { }
        public InsertionFailedException(string message, Exception inner) : base(message, inner) { }
    }
    class CustomExceptionDemo
    {
        static void Main(string[] args)
        {
            try
            {
                addNewEmployee();
            }
            catch (InsertionFailedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                deleteEmployee();
            }
            catch(EmployeeNotFoundException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
        }

        /// <summary>
        /// adds a new Employee
        /// </summary>
        /// <exception cref="SampleConApp.InsertionFailedException"/>
        static void addNewEmployee()
        {
            //take the inputs....
            //connect to the db
            //execute the command
            //command raises one exception
            //catch the exception, but throw custom Exception....
            throw new InsertionFailedException("Employee could not be inserted");
            //Exceptions are raised using throw keyword....
        }

        /// <summary>
        /// Deletes an Employee from the system.
        /// </summary>
        /// <exception cref="SampleConApp.EmployeeNotFoundException"/>
        static void deleteEmployee()
        {
            throw new EmployeeNotFoundException($"Employee with ID {123} not found to delete");
        }
    }
}