using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp68
{
    internal class Library
    {
        public List<Library> LibraryList=new List<Library>();
        public string FindAllBookByName(string Library)
        {
            
            foreach (int element in Library)
            {
                Library.Remove(element);
                Console.WriteLine(element);
            }
            return;
        }
    }
}
