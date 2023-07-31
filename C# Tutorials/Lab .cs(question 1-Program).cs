using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = getSum(num1, num2);
            Console.WriteLine("Sum: " + sum);
        }

        static int getSum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
