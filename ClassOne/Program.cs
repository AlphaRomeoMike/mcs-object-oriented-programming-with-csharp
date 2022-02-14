using System;

namespace ClassOne
{
    // Program class is the entry point of every single application in C#
    class Program
    {
        // Constructor, function or method
        public Program()
        {

        }
        // Main is the function which first runs on the execution of the program
        public static void Main()
        {
            // Cat is an object of animal class
            Animal cat = new Animal("Maano", 4, "Meoww!");
            System.Console.WriteLine(cat.name); // Output: Maano
            System.Console.WriteLine(cat.legs); // Output: 4
            System.Console.WriteLine(cat.GetVoice()); // Output: This animal speaks Meoww!
            cat.SetName("Dum dum");
            // Output: The animal's current name is Maano
            // Output: The animal's new name is Dum dum

            Animal dog = new Animal("Tommy", 4, "Barkk!");
            System.Console.WriteLine(dog.name); // Output: Tommy
            System.Console.WriteLine(dog.legs); // Output: 4
            System.Console.WriteLine(dog.GetVoice()); // Output: This animal speaks Barkk!
        }
    }
    class Animal
    {
        public string name;
        public int legs;
        public string voice;

        public Animal(string animalName, int animalLegs, string animalVoice)
        {
            this.name = animalName;
            this.legs = animalLegs;
            this.voice = animalVoice;
        }
        public string GetVoice()
        {
            return "This animal speaks " + this.voice;
        }

        public void SetName(string newName)
        {
            System.Console.WriteLine("The animal's current name is " + this.name);
            this.name = newName;
            System.Console.WriteLine("The animal's new name is " + newName);
        }
    }
}