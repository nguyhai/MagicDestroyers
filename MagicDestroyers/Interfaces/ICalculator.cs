using System;

// Interfaces------------------------------------------------------------------------------------------------------------------------
// An interface contains definitions for a group of related functionalities that a class or a struct can implement.
// By using interfaces, you can, for example, include behavior from multiple sources in a class. ... 
// In that way, an interface in C# is similar to an abstract class in which all the methods are abstract.
// The interface defines only the signature.
// However, a class or struct can implement multiple interfaces, but a class can inherit only a single class, abstract or not. 
// Therefore, by using interfaces, you can include behavior from multiple sources in a class.
// So basically, if you have an interface, with properties and methods, any class that implements the interface will be foreced to use the members in the interface. 
// Interfaces can contain methods, properties, events, indexers, or any combination of those four member types.
// No Fields, No Constants, No Constructors, no Statics, no Access Modifiers. 
// Interfaces are kept SIMPLE, no logic in them. 

namespace MagicDestroyers.Interfaces
{
    public interface ICalculator
    {
        // As you can see, the interface cannot have a definition. You can only have a SIGNATURE, of what the IMPLEMENTING class should have. It cannot have its
        // own properties or methods. 
        //public void Addition(int firstNumber, int secondNumber)
        //{
        //    Console.WriteLine(firstNumber + secondNumber);
        //}

        // Method, no return type, has the signature. NO access modifiers (public, etc)
        void Addition(int firstNumber, int secondNumber); // This is just the SIGNTURE. DONT ADD DEFINITION. DONT RETURN ANYTHING. 

    }
}
