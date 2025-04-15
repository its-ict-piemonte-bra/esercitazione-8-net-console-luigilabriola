using System;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book("Signore degli Anelli", "J.R.R. Tolkien", 1954, "Sinossi 1"),
                new Book("Dracula", "Bram Stoker", 1897, "Sinossi 2")
            };
            Library library = new Library(books);
            Library library2 = new Library(books);

            library[] libraries = { library, library2 };

            Console.WriteLine(library.ToString());
            Console.WriteLine(library.BooksOfAuthor("Bram Stoker"));

            Console.WriteLine(library.BooksOfAuthor(libraries, "Bram Stoker"));

            // Il metodo di instanza è relativo a una sola instanza
            Console.WriteLine(library.BooksPublisherBetween(1000, 2000));

            // I metodi statici vengono usati per eseguire metodi di istanza su
            // gruppi di istanze
            Console.WriteLine(library.BooksPublisherBetween(libraries, 1000, 2000));
        }
    }
}