namespace ClassTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reference of a class, local variable, sets a space in the memory
            Student student = new Student();
            Student student2 = new Student();
            Console.WriteLine("Code ran");
        }
    }

    class Student
    {
        public string Name;
        public int Age;
        public string Class;
        public float CGPA;
    }
}