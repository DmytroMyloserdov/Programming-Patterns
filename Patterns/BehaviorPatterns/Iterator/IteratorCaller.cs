using System;

namespace Patterns.BehaviorPatterns.Iterator
{
    public class IteratorCaller
    {
        public static void Call()
        {
            Book[] books = new Book[3]
            {
                new Book("CLR via C#"),
                new Book("Simple JavaScript"),
                new Book("Node.js")
            };

            Library library = new Library(books);

            foreach (var book in library)
            {
                Console.WriteLine(book.Name);
            }
        }
    }
}
