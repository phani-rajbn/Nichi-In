using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace SampleConApp.Entites
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; } = 100;//New in C# 6.0...
    }
}

namespace SampleConApp.Dal
{
    using System.Data;
    public interface IProductDataLib
    {
        void AddProduct(int id, string name, int price, int stock);
        void UpdateProduct(int id, string name, int price, int stock);
        void RemoveProduct(int id);
        DataTable FindProduct(string name);//DataTable is a data structure to hold values as Rows and columns and represent it as a Real time table of a Relational Database...
        DataRow FindProduct(int id);
    }

    public class ProductDatabase : IProductDataLib
    {
        DataTable table = new DataTable("Products");
        public ProductDatabase()
        {
            //create the schema for the table...
            table.Columns.Add("ProductID", typeof(int));
            table.Columns.Add("ProductName", typeof(string));
            table.Columns.Add("ProductCost", typeof(int));
            table.Columns.Add("ProductStock", typeof(int));
            table.PrimaryKey = new DataColumn[] { table.Columns[0] };
            table.AcceptChanges();
            AddProduct(123, "Test1", 234, 445);
            AddProduct(124, "Test2", 234, 445);
            AddProduct(125, "Test3", 234, 445);
            AddProduct(126, "Test1", 234, 445);
        }
        public void AddProduct(int id, string name, int price, int stock)
        {
            //create a new row..
            DataRow row = table.NewRow();
            //add values to the row
            row["ProductID"] = id;
            row[1] = name;
            row[2] = price;
            row[3] = stock;
            //add the row to the table.
            table.Rows.Add(row);
            table.AcceptChanges();
        }

        public DataTable FindProduct(string name)
        {
            DataTable found = table.Copy();//Creates a duplicate table...
            if (string.IsNullOrEmpty(name))
                return found;
            found.Rows.Clear();//Removes all the contents of the copy....
            foreach(DataRow row in table.Rows)
            {
                if (row[1].ToString().Contains(name))
                {
                    DataRow r = found.NewRow();
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        r[i] = row[i];
                    }
                    found.Rows.Add(r);
                }
            }
            found.AcceptChanges();
            return found;
            
        }

        public DataRow FindProduct(int id)
        {
            return table.Rows.Find(id);
        }

        public void RemoveProduct(int id)
        {
            //Find the matching row
            DataRow row = table.Rows.Find(id);
            if (row == null)
                throw new Exception($"Product with ID {id} not found to delete");
            //delete the row
            row.Delete();//It sets a property called RowState to deleted..
            //Accept the changes
            table.AcceptChanges();
        }

        public void UpdateProduct(int id, string name, int price, int stock)
        {
            throw new NotImplementedException("Do It URSELF");
        }
    }
}

namespace SampleConApp.UserInterface
{
    using SampleConApp;
    class MainProgram
    {
        static void Main(string[] args)
        {
            //WYSIWYG
           BookStore frm = new BookStore();
           frm.ShowDialog();//Modal Dialog box...
        }
    }
}