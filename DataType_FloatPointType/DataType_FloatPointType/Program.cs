using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_FloatPointType
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = float.MinValue;
            float y = float.MaxValue;

            Console.WriteLine("Float minimum value is = {0}, Float maximum value is = {1}", x, y);

            float a = 1F / 3;
            double b = 1D / 3;
            decimal c = 1M / 3;

            Console.WriteLine("\nFloat a = {0}\nDouble b = {1}\nDecimal c = {2}", a, b, c);


            Console.ReadKey();
        }
    }
}
