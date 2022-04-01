using System;

namespace ConsoleApp68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.FindAllBookByName("salam");
            Console.WriteLine(library.FindAllBookByName("salam"));
                
        }
    }
}
