using System.Collections;
using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Iterator
{
    internal class Library : IEnumerable<Book>
    {
        Book[] _books;

        public Library(Book[] books)
        {
            _books = books;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryNumerator(_books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class Book
    {
        public string Name { get; set; }

        public Book(string name)
        {
            Name = name;
        }
    }
}
