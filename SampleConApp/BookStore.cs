using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleConApp
{
    public partial class BookStore : Form
    {
        IBookStore store = new BookCollection();
        public BookStore()
        {
            InitializeComponent();
            store.AddNewBook(new Book { BookID = 1, Author = "Andrew Torslen", Title = "Pro C#" });
            store.AddNewBook(new Book { BookID = 2, Author = "Charles Dickens", Title = "Oliver Twist" });
            store.AddNewBook(new Book { BookID = 3, Author = "W Shakespear", Title = "Romeo and Juliet" });
            store.AddNewBook(new Book { BookID = 4, Author = "Mark Twain", Title = "Tom Sawyer" });
            store.AddNewBook(new Book { BookID = 5, Author = "Chetan Bhagat", Title = "2 States" });
        }

        private void BookStore_Load(object sender, EventArgs e)
        {
            populate();
            pnAddition.Visible = false;
            pnUpdation.Visible = false;
        }

        private void populate()
        {
            //List<Book> allBooks = store.GetAllBooks();
            List<Book> allBooks = new List<Book>();
            foreach (var book in store) allBooks.Add(book);
            lstBooks.DataSource = allBooks;
            lstBooks.DisplayMember = "Title";
            lstBooks.ValueMember = "BookID";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            pnAddition.Visible = true;
            pnUpdation.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var bk = new Book();
            bk.BookID = int.Parse(txtNewId.Text);
            bk.Title = txtNewTitle.Text;
            bk.Author = txtNewAuthor.Text;
            store.AddNewBook(bk);
            MessageBox.Show("Book added successfully");
            pnAddition.Visible = false;
            populate();
        }

        private void LstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bk = lstBooks.SelectedItem as Book;
            txtId.Text = bk.BookID.ToString();
            txtAuthor.Text = bk.Author;
            txtTitle.Text = bk.Title;
            pnUpdation.Visible = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var bk = new Book();
            bk.BookID = int.Parse(txtId.Text);
            bk.Title = txtTitle.Text;
            bk.Author = txtAuthor.Text;
            try
            {
                store.UpdateBook(bk);
                MessageBox.Show("Book updated to the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
