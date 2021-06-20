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
            //NOT EVERY SOLUTION IS TESTED HERE, SOME JUST WORKED - TODD HOWARD
            //NOT ALL REGEX PROBLEMS WERE SOLVED BY REGEX OR BY REGEX ONLY

            dynamic solution;

            #region 7kyu

            solution = SevenKyu.Vowel2Index("Codewars is the best site in the world");
            solution = SevenKyu.RemoveUrlAnchor("www.codewars.com#about");
            solution = SevenKyu.StringTask("Codewars");
            solution = SevenKyu.ValidatePin("1234\n");
            solution = SevenKyu.Gap(15);
            solution = SevenKyu.RemoveNoise("%$&/#·@|º\\ª");
            solution = SevenKyu.Remove("!c!q!!pRHF!!");
            solution = SevenKyu.IsItANum("S:)0207ERGQREG88349F82!efRF)");
            solution = SevenKyu.IpValidator("127.0.0.1");
            solution = SevenKyu.ShortForm("insane");
            solution = SevenKyu.Double_check("a b  c");
            solution = SevenKyu.ToCents("$12345678.90");
            string[][] a = { new[] { "foo", "foo@foo.com" }, new[] { "bar_", "bar@bar.com" } };
            solution = SevenKyu.search_names(a);


            #endregion 7kyu

            #region 6kyu

            solution = SixKyu.ToCamelCase("the_stealth_warrior");
            solution = SixKyu.CleverSplit("Buy a !car [!red green !white] [cheap or !new]");
            String[] robotTest = { "d[(0)(0)}b We're functioning automatik D[(0)(0)]b", "And we are d[(0)(0}]b dancing mechanik d[(0)(0)]b c[(0)(0)]b" };
            solution = SixKyu.CountRobots(robotTest);
            solution = SixKyu.Ermahgerd("my name is ohmygod girl and I love codewars!");
            solution = SixKyu.DecipherThis("72olle 103doo 100ya");
            solution = SixKyu.EncryptThis("A wise old owl lived in an oak");

            #endregion 6kyu

            #region 5kyu

            solution = FiveKyu.Rot13("Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.");

            #endregion 5kyu

            Console.ReadKey();
        }
    }
}
