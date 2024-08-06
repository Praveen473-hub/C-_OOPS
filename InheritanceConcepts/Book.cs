using System;

namespace InheritanceConcepts
{
    /*Abstraction starts here*/
    //Abstraction:
    //It involves the process of hiding the implementation details and showing only the essential features of the object.
    //Abstraction allows you to focus on what the object does rather than how it does it.

    //Abstraction focuses on hiding the internal implementation details and showing only the essential features of an object,
    //This can be achieved using abstract classes and interfaces.

    //Maintenance: With abstraction, maintenance becomes easier as changes in the implementation details do not affect the users of the class.
    //This promotes better modularization of code.
    //Reusability: Abstract classes and interfaces can be reused across different parts of an application or in different projects,
    //making the code more modular and maintainable.
    //Security: By exposing only necessary details and hiding the rest,
    //abstraction can provide a layer of security for the internal workings of an application.
    /*Abstraction ends here*/

    abstract class Book
    {
        //Properties
        public string Title;
        public string Author;
        public int Price;
        public int ISBN;
        public string Description;
        //Constructor
        public Book(string title,string author,int price,int isbn, string description) 
        {
            Title = title;
            Author = author;
            Price = price;
            ISBN = isbn;
            Description = description;
        }
        //Methods
        //Virtual Method ( Overriding Can be Done )
        public virtual void displayInfo() 
        {
            Console.WriteLine(Title);
            Console.WriteLine(Price);
        }
        //Abstract Method
        //abstract method can only be implemented in abstract class
        public abstract void GetDescription();
        //The abstract method is meant to be a placeholder,
        //For the functionality that must be provided by any non-abstract (concrete) class that inherits from the abstract class
        //The concrete class is responsible for providing the implementation for the abstract method.

        public void BookInformation()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(Price);
        }
        //Method Overloading
        public void BookInformation(string autherName)
        {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(Price);
            Console.WriteLine(Author);
        }
        //Method Overloading
        public void BookInformation(string autherName,int code)
        {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(Price);
            Console.WriteLine(Author);
            Console.WriteLine(ISBN);
        }
        //Compiler will decide which method to overload,
        //based on the number of input parameters / type of parameters 
    }
}
