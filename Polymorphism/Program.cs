using System;
using static System.Console;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism in C#");

            /* Polymorphism = "Many forms". (In C# Polymorphism occurs when we have many classes that are 
             * related to each other by Inheritance.) */

            // Inheritance allows derived classes to inherit methods and fields from base classes (parental classes).

            // Polymorphism uses those methods to perform different tasks.

            // This allows us to perform one single action in different ways.

            // Example (See below)

            // Now to see the output of all of these classes.

            // Create a new Animal object.
            Animal myAnimal = new Animal();

            // Create a new Dog object.
            Animal myDog = new Dog();

            // Create a new Cat object.
            Animal myCat = new Cat();

            // Creating a new Fox object.
            Animal myFox = new Fox();

            // Now to call the class method on all of these objects.
            myAnimal.animalSound();
            myDog.animalSound();
            myCat.animalSound();
            myFox.animalSound();
            // The output for now will be the same for all of these classes which is "The animal makes a sound".

            // This is because only the method for the Base class is called upon. We have to change that.

            // The Base Class method overrides the Derived Class methods because they share the same name.

            // We can override the Base Class method by using the virtual keyword inside the Base Class (See below).

            // Inheritance and Polymorphism works together. They're useful for code reusability (Reusing fields and methods of an existing base class when creatíng a new child class).
        }
        class Animal // Base Class (Parent Class)
        {
            // Always use public void to create a method.

            // public virtual void = To override the Base Class method.
            public virtual void animalSound() // Method called animalSound() with a parameter.
            {
                WriteLine("The animal makes a sound.");
            }
        }

        class Dog : Animal // Derived Class (Child Class) that Inherits from Base Class (Parent Class) Animal
        {
            /* public override void = Works together with the public virtual void keyword in the Base Class so that 
             * these methods in the Derived Classes can be called upon. */
            public override void animalSound()
            {
                WriteLine("The dog goes: 'Woof, woof'");
            }
        }

        // Second Derived Class (Child Class) that Inherits from Parent Class Animal
        class Cat : Animal
        {
            public override void animalSound()
            {
                WriteLine("The cat goes: 'Meow, meow'");
            }
        }
        

        // Third Derived Class (Child Class) that Inherits from Parent Class Animal
        class Fox : Animal
        {
            // Using public override void together with public virtual void in Base Class to use this method.
            public override void animalSound()
            {
                WriteLine("What does the fox say? : Ding ding ding ding.");
            }
        }
    }
}
