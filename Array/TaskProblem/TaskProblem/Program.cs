using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenNumbers = new int[10]; // Since there are 10 even numbers in the given range

            // Use a for loop to assign even numbers to the array
            for (int i = 1, index = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[index] = i;
                    index++;
                }
            }

            // Display the cube of each item in the array
            Console.WriteLine("Cube of Even Numbers:");

            foreach (int number in evenNumbers)
            {
                int cube = number * number * number;
                Console.WriteLine($"{number}^3 = {cube}");
            }
            Console.ReadKey();
        }
    }
}
