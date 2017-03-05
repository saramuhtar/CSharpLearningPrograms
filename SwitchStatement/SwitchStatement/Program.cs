using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string myAnimal = "Cat";

            switch (myAnimal)
            {
                case "Canary":
                    Console.WriteLine("My animal is the Canary Bird.");
                    break;
                case "Cat":
                    Console.WriteLine("My animal is a Cat.");
                    break;
                case "Camel":
                    Console.WriteLine("My animal is a Camel.");
                    break;
                default:
                    Console.WriteLine("Non");
                    break;
            }

            int myVar = 15;
            switch(myVar)
            {
                case 10:
                    Console.WriteLine("\n\nMy Variable number is 10");
                    break;
                case 7:
                    Console.WriteLine("\n\nMy Variable number is 7");
                    break;
                case 4:
                    Console.WriteLine("\n\nMy Variable number is 4");
                    break;
                default:
                    Console.WriteLine("\n\nNon of the numbers are mine.");
                    break;

            }
            /* Define a string whatHeSay and assing the value "Hello" and check what the variable
               value among these cases "hello", "Bye", "welcome", or NoOne is the default and print the result
               and why?*/

            string whatHeSay = "Hello";
            switch (whatHeSay)
            {
                case "hello":
                    Console.WriteLine("\n\nThe string is hello");
                    break;
                case "Bye":
                    Console.WriteLine("\n\nThe string is Bye");
                    break;
                case "welcome":
                    Console.WriteLine("\n\nThe string is welcome");
                    break;
                default:
                    Console.WriteLine("\n\nNon of the words are the correct String");
                    break;

            }
            Console.ReadKey();
            }
    }
}
