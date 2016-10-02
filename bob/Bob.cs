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
            else if (saidNothing(inputString))
            {
                outputString = "Fine. Be that way!";
            }
            return outputString;
        }

        public static bool isShout(string inputString)
        {
            bool hasCharacter = false;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (Char.IsLetter(inputString[i]))
                {
                    hasCharacter = true;
                    if (Char.IsLower(inputString[i]))
                    {
                        return false;
                    }
                }
            }
            return hasCharacter;
        }

        public static bool isQuestion(string inputString)
        {
            inputString = inputString.Trim();
            if (inputString.Length == 0)
            {
                return false;
            }
            if ((inputString[(inputString.Length - 1)]).Equals('?'))
            {
                return true;
            }
            return false;
        }

        public static bool saidNothing(string inputString)
        {
            if(inputString.Length == 0)
            {
                return true;
            }
            for (int i = 0; i < inputString.Length; i++)
            {
                if(inputString[i] != ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
