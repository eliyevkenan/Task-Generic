using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp68
{
    internal class Book
    {
        static int _no;
        public Book()
        {
            _no++;
        }
        public string Name;
        public string AuthorName;
        public int PageCount;
    }
}
