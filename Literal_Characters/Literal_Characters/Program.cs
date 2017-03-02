using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = -100;
            uint myuVar = 1000;
            long myLVar = 1000l;

            float myFlVar = 5.9f;
            double mydblVar = 543.85;
            decimal mydecVar = 100.85m;


            Console.WriteLine("{0} \n{1} \n{2}", myVar, myuVar, myLVar);
            Console.WriteLine($"\n\n\n\n{myFlVar}, \n{mydblVar}, \n{mydecVar}");

            Console.ReadKey();
        }
    }
}
