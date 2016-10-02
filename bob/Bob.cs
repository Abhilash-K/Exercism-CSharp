using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_CSharp.csharp.bob
{
    public class Bob
    {
        public static string Hey(string inputString)
        {
            string outputString = "Whatever.";
            if (isShout(inputString))
            {
                outputString = "Whoa, chill out!";
            }
            else if (isQuestion(inputString))
            {
                outputString = "Sure.";
            }
            return outputString;
        }

        public static bool isShout(string inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if (Char.IsLetter(inputString[i]))
                {
                    if (Char.IsLower(inputString[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool isQuestion(string inputString)
        {
            if ((inputString[(inputString.Length - 1)]).Equals('?'))
            {
                return true;
            }
            return false;
        }
    }
}
