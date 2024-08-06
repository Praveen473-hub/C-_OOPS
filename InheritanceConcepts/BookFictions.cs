using System;

namespace InheritanceConcepts
{
    //Inheritance:
    //Inheritance is a mechanism where a new class inherits properties and methods from an existing class.
    //The class that inherits is called a derived or child class,
    //the class being inherited from is called a base or parent class.

    //1.Single Inheritance
    internal class BookFictions:Book
    {
        //Properties
        public string Genre;
        //Constructor
        public BookFictions(string title,string author,int price,int isbn,string description,string genre)
            :base(title,author,price,isbn,description)
        {
            Genre = genre;
        }
        //Overriding the virtual Method in base class
        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine("Overriding the virtual base class method from Derived Class");
        }
        public override void GetDescription()
        {
            Console.WriteLine(Description);
        }
    }
    //There are another 3 types of inheritance's
}
