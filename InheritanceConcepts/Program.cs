using System;

namespace InheritanceConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookFictions fbook = new BookFictions("Invisible Man", "Jalander", 473, 5503138, "Testing Overriding of abstraction class", "SCI FI");
            fbook.BookInformation();
            fbook.BookInformation("string");
            fbook.BookInformation("string",473);
            Console.ReadKey();
        }
    }
}
