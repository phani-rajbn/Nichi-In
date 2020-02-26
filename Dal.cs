using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLib
{
    public interface IDataComponent
    {
        void AddEmployee(int id, string name, string address, double salary);
        void UpdateEmployee(int id, string name, string address, double salary);
        DataTable GetAllEmployees();
        void DeleteEmployee(int id);
    }

    public class DataFactory
    {
        public static IDataComponent CreateComponent()
        {
            return new DataComponent();
        }
    }

    class DataComponent : IDataComponent
    {
        const string CONNECTIONSTRING = @"Data Source=.\SQLEXPRESS01;Initial Catalog=SampleDatabase;Integrated Security=True";
        public void AddEmployee(int id, string name, string address, double salary)
        {
            //Create a Connection
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            //write the query
            string query = $"Insert into Emptable values('{name}','{address}',{salary})";
            //create the command
            SqlCommand cmd = new SqlCommand(query, con);
            //execute the query
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            //handle any exceptions...
        }

        public void DeleteEmployee(int id)
        {
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            string query = "DELETE FROM EMPTABLE WHERE EMPID = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetAllEmployees()
        {
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            string query = "SELECT * FROM EMPTABLE";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();//ExecuteReader is the method that executes UR query and returns a DataReader object thro which U read the data. The reader object reads the data in a forward only and read only manner...
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateEmployee(int id, string name, string address, double salary)
        {
            //Create a Connection
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            //write the query
            string query = $"Update EmpTable set Empname = '{name}', Empaddress = '{address}', empsalary = {salary} where empid = {id}";
            //create the command
            SqlCommand cmd = new SqlCommand(query, con);
            //execute the query
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            //handle any exceptions...
        }
    }
}
