using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_CSharp.csharp.hello_world
{
    public class HelloWorld
    {
        public static string Hello(string inputString)
        {
            string outputString = "Hello, World!";

            if(inputString != null)
            {
                outputString = "Hello, " + inputString + "!";
            }
            return outputString;
        }
    }
}
