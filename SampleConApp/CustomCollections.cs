using System;
using System.Collections;
using System.Collections.Generic;
/*
 * A Class is said to be a collection class if it implements an interface IEnumerable. A collection class is one whose object can be used for iteration, implies Usable in a foreach statement.  
 */
namespace SampleConApp
{
    class Book 
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book Clone()
        {
            var clone = this.MemberwiseClone() as Book;
            return clone;
        }
    }

    interface IBookStore : IEnumerable<Book>
    {
        void AddNewBook(Book book);
        void DeleteBook(int id);
        void UpdateBook(Book book);

        List<Book> GetAllBooks();
    }
    class BookCollection : IBookStore
    {
        
        List<Book> _allBooks = new List<Book>();
        public void AddNewBook(Book book)
        {
            _allBooks.Add(book);
        }

        public void DeleteBook(int id)
        {
            for (int i = 0; i < _allBooks.Count; i++)
            {
                if (_allBooks[i].BookID == id)
                {
                    _allBooks.Remove(_allBooks[i]);
                    return;
                }
            }
            throw new Exception($"No Book by ID {id} found to delete");
        }

        public List<Book> GetAllBooks()
        {
            return _allBooks;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book bk in _allBooks)
                yield return bk;
        }
        
        public void UpdateBook(Book book)
        {
            //Find the matching Book based on the ID
            var foundBook = _allBooks.Find((bk)=> bk.BookID == book.BookID);
            //Throw Exception if the book is not found
            if (foundBook == null) throw new Exception("Book not found to update");
            //Set the values to the found book
            foundBook.Author = book.Author;
            foundBook.Title = book.Title;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    class SimpleCollection : IEnumerable
    {
        private List<string> items = new List<string>();
        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void RemoveItem(int id)
        {
            items.RemoveAt(id);
        }
      

        public IEnumerator GetEnumerator()
        {
           // return items.GetEnumerator();
            foreach (var item in items) yield return item;
            //yeild is a keyword used to return IEnumerator of the item....
        }
    }
    class CustomCollectionDemo
    {
        static void Main(string[] args)
        {
            //simpleIteration();
            //customExample();
            //IBookStore store = new BookCollection();
            //store.AddNewBook(new Book { BookID = 1, Author = "Andrew Torslen", Title = "Pro C#" });
            //store.AddNewBook(new Book { BookID = 2, Author = "Charles Dickens", Title = "Oliver Twist" });
            //store.AddNewBook(new Book { BookID = 3, Author = "W Shakespear", Title = "Romeo and Juliet" });
            //store.AddNewBook(new Book { BookID = 4, Author = "Mark Twain", Title = "Tom Sawyer" });
            //store.AddNewBook(new Book { BookID = 5, Author = "Chetan Bhagat", Title = "2 States" });

            Book bk = new Book { BookID = 444, Author = "Test1", Title = "Testing" };
            var copy = bk;
            Console.WriteLine(copy == bk);
            copy.Title = "Apple123";
            Console.WriteLine($"{copy.Title} and {bk.Title}");
            //foreach (var book in store) Console.WriteLine(book.Title);
        }

        private static void customExample()
        {
            var collection = new SimpleCollection();
            collection.AddItem("Apples");
            collection.AddItem("Samsung");
            collection.AddItem("Burger");
            collection.AddItem("TV");

            foreach (var item in collection) Console.WriteLine( item);
            var it = collection.GetEnumerator();
            while (it.MoveNext()) Console.WriteLine(it.Current);
        }

        private static void simpleIteration()
        {
            const int size = 5;
            Array temp = Array.CreateInstance(typeof(string), size);
            for (int i = 0; i < size; i++)
            {
                temp.SetValue(i.ToString(), i);
            }
            foreach (var val in temp) Console.WriteLine(val);
        }
    }
}