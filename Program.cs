using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
            int totalNumbers = 5;
            int sum = 0;

            Console.WriteLine("Please enter {totalNumbers} numbers:");

            for (int i = 1; i <= totalNumbers; i++)
            {
                Console.Write("Number {i}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Retry input for the same number
                }
            }

            Console.WriteLine("The sum of the {totalNumbers} numbers is: {sum}");
        }
    }
}
To use this code:

Open a new C# console application in your preferred development environment (e.g., Visual Studio, Visual Studio Code with C# extension).
Replace the existing code with the code provided above.
Build and run the program.
The program will prompt you to input 5 numbers one by one, and then it will display the sum of those numbers. If an invalid input (non-integer) is entered, the program will prompt you again for the same number until a valid input is given.






        }
    }
}
