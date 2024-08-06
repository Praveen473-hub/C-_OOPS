using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Advantages of OOP
            //Modularity: Objects can be created as separate modules, which can be integrated into a larger system.
            //Reusability: Code can be reused through inheritance and polymorphism.
            //Scalability: Easier to manage and scale applications due to the modular nature of objects.
            //Maintainability: Changes in one part of the application can be made with minimal impact on others.
            //Encapsulation: Protects the internal state of objects by restricting access to their data.

            //Disadvantages of OOP
            //Complexity: OOP can be more complex than procedural programming due to its reliance on objects and classes.
            //Performance: OOP can introduce performance overhead due to its abstraction and encapsulation mechanisms.
            //Size: OOP applications can be larger in size due to the need to create multiple objects and classes.

            //Do's and Don'ts of OOP

            //Do's:
            //Use meaningful names for classes, methods, and properties.
            //Follow the SOLID principles to design robust and maintainable systems.
            //Use design patterns where applicable.
            //Keep methods small and focused on a single task.
            //Use comments and documentation to explain the purpose of complex code.

            //Don'ts:
            //Avoid deep inheritance hierarchies as they can become difficult to manage.
            //Do not use global variables; prefer encapsulated fields.
            //Avoid overusing static methods and properties as they can lead to tightly coupled code.
            //Do not expose internal state directly; use properties and methods to control access.
            //Avoid writing overly complex and nested code blocks.

            //Can i use Private Attributes in Abstract Class:
            //Yes, you can use private attributes in an abstract class.
            //Private attributes help encapsulate the data within the class,
            //ensuring it can only be accessed or modified through public properties or methods.
            //In an abstract class, these private attributes will not be directly accessible by derived classes, which maintains encapsulation.


            /*Encapsulation Starts Here*/
            //Encapsulation:

            //public string title{get;set};
            //public string author{get;set};
            //public string isbn{get;set};
            //public bool isCheckedOut{get;set};

            //Public Attributes:
            //When you declare data members(fields) as public,
            //they can be accessed and modified directly from outside the class.
            //This can make the code more straightforward but can also lead to potential issues
            //if the data is manipulated in unintended ways.

            //private string title;
            //private string author;
            //private string isbn;
            //private bool isCheckedOut;

            //public string Title
            //{
            //    get { return title; }
            //    set { title = value; }
            //}

            //public string Author
            //{
            //    get { return author; }
            //    set { author = value; }
            //}

            //public string ISBN
            //{
            //    get { return isbn; }
            //    set { isbn = value; }
            //}

            //public bool IsCheckedOut
            //{
            //    get { return isCheckedOut; }
            //    private set { isCheckedOut = value; }
            //}

            //Private Attributes:
            //Declaring data members as private encapsulates them within the class,
            //ensuring that they can only be accessed and modified through methods or properties within the same class.
            //This is a safer approach as it protects the integrity of the data.

            //Which is Better: Public or Private?
            //Public: Easier to access and modify but can lead to less control over the data.
            //Private: Provides better encapsulation and control over how the data is accessed and modified, leading to more robust and maintainable code.
            /*Encapsulation ends Here*/
        }
    }
}
