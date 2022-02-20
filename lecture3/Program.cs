namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Profile("Muhammad Sami", "Farid", 24, "Male");
            System.Console.WriteLine(person.getName());
            System.Console.WriteLine(person.getAge());

            Student student = new Student();
            student.Profile("Ehsan", "Elahi", 30, "Male", 64141, Convert.ToSingle(4.0));
            System.Console.WriteLine(student.GetProfile());
        }

    }

    // Base Class/Parent Class
    // extension of the base class
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Gender;

        public void Profile(string firstName, string lastName, int age, string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
        }

        public string getName()
        {
            return "The person's name is " +this.FirstName + " " + this.LastName;
        }

        public string getAge()
        {
            return "Age of " +  this.FirstName + " " + this.LastName + " is " + this.Age;
        }
        public string getGender()
        {
            return this.Gender;
        }
    }
    // Child Class
    class Student : Person
    {
        public int StudentId;
        public float CGPA;

        public void Profile(string firstName, string lastName, int age, string gender, int studentId, float cgpa)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.StudentId = studentId;
            this.CGPA = cgpa;
        }

        public string GetProfile()
        {
            return "Student name is " + this.FirstName + " " + this.LastName + " and his CGPA is " + this.CGPA;
        }
    }
    class Employee : Person 
    {
        public int EmployeeId;
        public string Department;
    }
}