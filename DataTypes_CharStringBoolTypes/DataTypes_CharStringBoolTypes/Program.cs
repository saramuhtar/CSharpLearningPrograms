using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            char myVar = 'D';
            int myVarValue = 'D';

            char o = 'd';
            int p = 'd';

            char myVarValue2 = Convert.ToChar(myVarValue);

            Console.WriteLine("The Minimum Value for the char is = {0} \nThe Maximum Value for the char is = {1} \nMy Character is = {2} \nMy Character Value is = {3} \nMy Character is = {4} \nMy Character Value is = {5} \nThe Conversion is = {6}"
                , charMin, charMax, myVar, myVarValue, o, p, myVarValue2);

            string myString = "This is my variable";

            Console.WriteLine("\n\n\n\nMy string is = {0}", myString);

            bool myBool = true;
            bool v = false;

            Console.WriteLine("\n\n\n\nMy Boolean Value is = {0} \nMy other Boolean Value is = {1}", myBool, v);

            Console.ReadKey();
        }
    }
}
