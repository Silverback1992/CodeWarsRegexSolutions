using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsRegexSolutions
{
    public static class FiveKyu
    {
        public static bool Alphanumeric(string str)
        {
            return Regex.IsMatch(str, @"^(?i)[a-z0-9]+\z");
        }

        public static string Rot13(string input)
        {
            var rot13 = input.Select(x =>
            {
                if(char.IsLetter(x))
                {
                    if (char.IsUpper(x))
                        return x + 13 > 90 ? (char)(x - 13) : (char)(x + 13);

                    if (char.IsLower(x))
                        return x + 13 > 122 ? (char)(x - 13) : (char)(x + 13);
                }

                return x;
            });

            return String.Join("", rot13);
        }
    }
}
