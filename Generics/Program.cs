using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            var numberCompare = new Utilities<int>();
            Console.WriteLine(numberCompare.Max(1, 2));

            var book = new Book { Isbn = "123", Title = "C# Generics" };

            var numberOne = new List();
            numberOne.Add(10);

            var books = new BookList();
            books.Add(book);

            var genlist = new GenericList<int>();
            genlist.Add(10);

            var genBooks = new GenericList<Book>();
            genBooks.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

        }
    }
}
