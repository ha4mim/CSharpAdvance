using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionofNumbersApp
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number:");
            int lastNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum is:"+ GetAddition(firstNumber, lastNumber));
            Console.ReadKey();
        }
        public static int GetAddition(int a, int b)
        {

            return a + b;
        }
    }
}
