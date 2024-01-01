using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRollNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] rollNumber = new int[size];
            Console.WriteLine($"Your array size is: {size}");
            for (int i = 0; i < rollNumber.Length; i++)
            {
                rollNumber[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your Numbers are:");
            for(int i = 0; i < rollNumber.Length; i++)
            {
                Console.WriteLine(rollNumber[i]);
            }
            Console.WriteLine("Task Done!");
            Console.ReadKey();
        }
    }
}
