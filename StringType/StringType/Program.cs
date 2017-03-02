using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        // \'  \"  \\  \0  \a  \b  \n  \r  \t  \v  \f
        // @
        static void Main(string[] args)
        {
            string myString = "This is my String Variable";
            string myString2 = "Sara Said : \"This is a good course\", and i think";
            string myString3 = "Sara Said : \'This is a good course\', and i think";
            string myString4 = "Sara Said : \\This is a good course\\, and i think";
            string myString5 = "Sara Said : \0This is a good course\0, and i think";
            string myString6 = "Sara Said : \aThis is a good course\a, and i think";
            string myString7 = "Sara Said : \bThis is a good course\b, and i think";
            string myString8 = "Sara Said : This is a good course,\n and i think";
            string myString9 = "Sara Said : This is a good course\r, and i think";
            string myString10 = "Sara Said : \tThis is a good course\t, and i think";
            string myString11 = "Sara Said : \vThis is a good course\v, and i think";
            string myString12 = "Sara Said : \fThis is a good course\f, and i think";

            string myString13 = @"C:\Users\Silver\Documents\visual studio 2015\Projects\Literal_Characters\Literal_Characters\bin";

            string myString14 = @"C:\Users\Silver\Documents\visual studio 2015\Projects\
Literal_Characters\Literal_Characters\bin";

            string myString17 = " yes it is";
            string myString15 = myString + myString4;
            string myString16 = myString + myString17;

            string myString18 = @"Sara has said ";
            string myString19 = @"'This is a unique course'";
            string myString20 = @", and I think so";
            string myString21 = myString18 + myString19 + myString20; 
            

            Console.WriteLine("{0}", myString);
            Console.WriteLine("\n\n{0}", myString2);
            Console.WriteLine("\n\n{0}", myString3);
            Console.WriteLine("\n\n{0}", myString4);
            Console.WriteLine("\n\n{0}", myString5);
            Console.WriteLine("\n\n{0}", myString6);
            Console.WriteLine("\n\n{0}", myString7);
            Console.WriteLine("\n\n{0}", myString8);
            Console.WriteLine("\n\n{0}", myString9);
            Console.WriteLine("\n\n{0}", myString10);
            Console.WriteLine("\n\n{0}", myString11);
            Console.WriteLine("\n\n{0}", myString12);

            Console.WriteLine("\n\n{0}", myString13);
            Console.WriteLine("\n\n{0}", myString14);

            Console.WriteLine("\n\n{0}", myString15);

            Console.WriteLine("\n\n{0}", myString16);
            Console.WriteLine("\n\n{0}", myString21);
            Console.ReadKey();



        }
    }
}
