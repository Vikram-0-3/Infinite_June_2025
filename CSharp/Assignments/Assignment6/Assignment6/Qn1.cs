
using System;

namespace Books
{
    class Books
    {
        public string BookName;
        public string AuthorName;

        public Books(string bookname, string authorname)
        {
            BookName = bookname;
            AuthorName = authorname;
        }

        public void Display()
        {
            Console.WriteLine("Book Name - " + BookName);
            Console.WriteLine("Author Name - " + AuthorName);
        }
    }

    class BookShelf
    {
        Books[] BookList = new Books[5];
        public Books this[int Index]
        {
            get { return BookList[Index]; }
            set { BookList[Index] = value; }
        }
    }

    class Qn1
    {
        static void Main()
        {
            BookShelf Shelf = new BookShelf();

            Shelf[0] = new Books("A", "Vikram");
            Shelf[1] = new Books("B", "rajan");
            Shelf[2] = new Books("C", "vik");
            Shelf[3] = new Books("D", "viks");
            Shelf[4] = new Books("E", "rajan");

            Shelf[0].Display();
            Shelf[1].Display();
            Shelf[2].Display();
            Shelf[3].Display();
            Shelf[4].Display();
            Console.Read();
        }
    }
}
