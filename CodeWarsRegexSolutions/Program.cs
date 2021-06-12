using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsRegexSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic solution;

            #region 7kyu

            solution = SevenKyu.Vowel2Index("Codewars is the best site in the world");
            solution = SevenKyu.RemoveUrlAnchor("www.codewars.com#about");
            solution = SevenKyu.StringTask("Codewars");
            solution = SevenKyu.ValidatePin("1234\n");
            
            #endregion 7kyu

            Console.ReadKey();
        }
    }
}
