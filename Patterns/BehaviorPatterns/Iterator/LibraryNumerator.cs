using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Iterator
{
    internal class LibraryNumerator : IEnumerator<Book>
    {
        public Book[] _books;
        int _position = -1;

        public Book Current
        {
            get
            {
                try
                {
                    return _books[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public LibraryNumerator(Book[] list)
        {
            _books = list;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _books.Length;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
