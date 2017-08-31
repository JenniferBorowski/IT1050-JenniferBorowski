using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jennifer Borowski";
            string greeting = "Hello";

            Console.WriteLine("Hello World from Jennifer Borowski");

            // One way to output the variables' values
            Console.WriteLine("{0} from {1}", greeting, name);

            // Another way to output their values using string concatenation
            Console.WriteLine(greeting + " from " + name);
        }
    }
}
