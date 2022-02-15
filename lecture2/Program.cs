namespace Lecture2
{
   class Program
   {
      public static void Main()
      {
         Animal cat = new Animal();
         cat.SetName("Tom");
         cat.SetAge(2);

         // System.Console.WriteLine("Name of the cat is " + cat.Name + " and age is " + cat.Age);

         Dog dog = new Dog();
         dog.SetName("Fido");
         dog.SetAge(3);

         System.Console.WriteLine("Name of the dog is " + dog.Name + " and age is " + dog.Age);
         dog.Bark();
      }
   }

   class Animal
   {
      // ? represents nullable type
      public string? Name;
      public int? Age;
      public void SetName(string name)
      {
         Name = name;
      }
      public void SetAge(int age)
      {
         Age = age;
      }
   }

   // class ChildClass extends ParentClass
   class Dog : Animal
   {
      public void Bark()
      {
         Console.WriteLine(this.Name + " says Woof!");
      }
   }
}