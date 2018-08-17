using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputStringForCheckCount = int.Parse(Console.ReadLine());
            List<char> characterForCheck = new List<char>();

            bool isBalanced = false;
            int openBracketCounter = 0;
            int closeBracketCounter = 0;

            for (int i = 0; i < inputStringForCheckCount; i++)
            {
                string inputStringForCheck = Console.ReadLine();


                if (inputStringForCheck.Length > 1)
                {
                    continue;
                }
                else
                {
                    characterForCheck.Add(inputStringForCheck.ToCharArray()[0]);
                }
            }

            foreach (var symbol in characterForCheck)
            {
                if (symbol == ')')
                {
                    closeBracketCounter++;
                    if (openBracketCounter == closeBracketCounter)
                    {
                        isBalanced = true;
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
                else
                {
                    if (symbol == '(')
                    {
                        openBracketCounter++;
                        if (openBracketCounter == closeBracketCounter)
                        {
                            isBalanced = true;
                        }
                        else
                        {
                            isBalanced = false;
                            //break;
                        }
                    }
                }
            }


            // Console.WriteLine();
            // Console.WriteLine();
            // characterForCheck.ForEach(Console.WriteLine);

            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
