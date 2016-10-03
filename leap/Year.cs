using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_CSharp.csharp.leap
{
    public class Year
    {
        public static bool IsLeap(int inputYear)
        {
            if(inputYear % 4 == 0)
            {
                if(inputYear % 100 == 0)
                {
                    if(inputYear % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
