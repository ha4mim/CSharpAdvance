using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your last number:");
            int lastNumber = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[lastNumber];
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter Your {i + 1} number:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum = sum+numbers[i];
            }
            Console.WriteLine("The Sum is: {0} ", sum);
            Console.ReadKey();
        }
    }
}
