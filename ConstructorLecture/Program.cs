namespace ConstructorLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prioritize calling mechanism! This means, it will always
            // run as soon as the object is instantiated

            // Constructor overloading can be applied on Parameterized constructor
            // If you have similar range of parameters in different constructors, then we
            // should make sure about the data type of the parameters
            Student student = new Student("Rizwan Arshad");
            Console.WriteLine($"Student name is {student.Name} and Student id is: {student.Id}");
        }
    }

    class Student
    {
        public int? Id;
        public string? Name;

        public Student()
        {
            Console.WriteLine("Student Constructor invoked!");
        }

        // Constructor can have multiple paramatereized list which enables us 
        // create multiple objects
        static Student()
        {
            Console.WriteLine("Static Student Constructor invoked!");
        }

        public Student(string? name)
        {
            Random random = new Random();
            this.Id = random.Next();
            this.Name = name;
        }
    }
}