using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsForTheCharacterAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            char myFirstChar = 'A';
            int myFirstCharValue = 'A';

            char mySecondChar = 'a';
            int mySecondCharValue = 'a';

            string myString1 = "This is my Character A Value";
            string myString2 = "This is my Character a Value";

            //char myVarValue2 = Convert.ToChar(myVarValue);

            Console.WriteLine("This is my First Character {0} \n{1} = {2} \nThis is my Second Character {3} \n{4} = {5}"
                , myFirstChar ,myString1, myFirstCharValue ,mySecondChar , myString2, mySecondCharValue);          
            
            Console.ReadKey();
        }
    }
}
