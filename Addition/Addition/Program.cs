using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int sum;

            Console.Write("Enter the first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            sum = x + y;

            Console.WriteLine("The value of the sum is: {0} ", sum);

        }
    }
}
