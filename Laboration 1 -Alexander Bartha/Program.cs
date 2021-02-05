using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Laboration_1__Alexander_Bartha
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input a string.");
            Console.Write("Your string: "); string inputString = Console.ReadLine();
            Console.WriteLine("Possible combinations:\n_________________\n");                        
            List<string> substringList = new List<string>();

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (char.IsDigit(inputString, i))
                {                       
                    for (int j = i + 1; j < inputString.Length; j++)
                    {
                        if (!char.IsDigit(inputString[j])) //Avbryta ifall bokstav dyker upp
                        {
                            break;
                        }

                        else if ( inputString[i] == inputString[j]) //Matcha siffra på index i med index j och dela upp i substrängar
                        {
                            int matchStartIndex = i;
                            int matchIndexLength = j - i + 1;
                            int matchEndIndex = j + 1;
                            string subStringMatch = inputString.Substring(startIndex: matchStartIndex, matchIndexLength);
                            string subStringBefore = inputString.Substring(startIndex: 0, matchStartIndex);
                            string subStringAfter = inputString.Substring(startIndex: matchEndIndex);
                            Console.Write(subStringBefore);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(subStringMatch);
                            substringList.Add(subStringMatch);
                            Console.ResetColor();
                            Console.Write(subStringAfter);
                            Console.Write("\n");

                            break;
                        }
                        
                    }
                      
                }                   

            }

            Console.WriteLine("_________________\n\nThe value of the substrings combined is: " +
            (substringList.Sum(x => Convert.ToInt64(x))) + "."); // Skriva ut det kombinerade värdet av alla substrings

            Console.ReadKey();

        }
    }
}
