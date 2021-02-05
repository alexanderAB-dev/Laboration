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

            Console.WriteLine("Please input a string");
            Console.Write("Your string: "); string inputString = Console.ReadLine();
            Console.WriteLine("Possible combinations:\n_________________\n");


            string subStringMatch;
            string subStringEnd;
            string subStringStart;
            List<string> combinationValue = new List<string>();
            for (int i = 0; i < inputString.Length - 1; i++)
            {


                if (char.IsDigit(inputString, i))
                {

                    
                   
                    for (int j = i + 1; j < inputString.Length; j++)
                    {
                        if (!char.IsDigit(inputString[j])) //avbryta ifall bokstav dyker upp
                        {
                            break;
                        }

                        else if ( inputString[i] == inputString[j])
                        {
                            

                            subStringMatch = inputString.Substring(startIndex: i, j - i + 1);
                            subStringStart = inputString.Substring(startIndex: 0, i);
                            subStringEnd = inputString.Substring(startIndex: j + 1);
                            Console.Write(subStringStart);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(subStringMatch);
                            combinationValue.Add(subStringMatch);
                            Console.ResetColor();
                            Console.Write(subStringEnd);
                            Console.Write("\n");


                            break;

                        }
                        
                    }
                      
                }

               


            }

            Console.WriteLine("_________________\n\nThe value of the substrings combined is: " + (combinationValue.Sum(x=>Convert.ToInt64(x)))+".");
            Console.ReadKey();

        }
    }
}
