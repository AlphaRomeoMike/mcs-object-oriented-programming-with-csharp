using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class App
    {
        public static string Name = "Banking Application";

        public static string Description = "Welcome to banking application";

        public static void Welcome()
        {
            Console.WriteLine($"{Name}\n{Description}");
        }
    }
}
