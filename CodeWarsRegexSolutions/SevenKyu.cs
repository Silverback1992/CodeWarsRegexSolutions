using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsRegexSolutions
{
    public static class SevenKyu
    {
        public static string Vowel2Index(string str)
        {
            StringBuilder sb = new StringBuilder();
            int counter = 1;

            foreach (char c in str)
            {
                if (Regex.IsMatch(c.ToString(), "[aiueo]"))
                    sb.Append(counter);
                else
                    sb.Append(c);

                counter++;
            }

            return sb.ToString();

            //Beautiful alternative solution:
            //return  Regex.Replace(str, "[aeiou]", x => (x.Index + 1).ToString());
        }

        public static string RemoveUrlAnchor(string url)
        {
            return Regex.Match(url, "^([^#]+)").Groups[1].Value;
        }

        public static string StringTask(string s)
        {
            return String.Join("", Regex.Replace(s.ToLowerInvariant(), "[aoyeui]", x => "")
                .Select(c => $".{c}"));
        }

        public static bool ValidatePin(string pin)
        {
            return !pin.Contains('\n') ? Regex.IsMatch(pin, @"^(\d{4}|\d{6})$") : false;
        }

        public static string RemoveDuplicateWords(string s)
        {
            var result = new List<string>();
            
            foreach (var word in s.Split(' '))
            {
                if (!result.Contains(word))
                    result.Add(word);
            }

            return String.Join(" ", result);
        }

        public static bool EightBitNumber(this string str)
        {
            return Regex.IsMatch(str, @"^(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\z");
            //return byte.TryParse(s, out var n) && s.Length == $"{n}".Length;
            //return Enumerable.Range(0, 256).Any(c => c.ToString().Equals(str));
        }

        public static bool SixBitNumber(this string str)
        {
            return Regex.IsMatch(str, @"^(\d|[1-5]\d|6[0-3])\z");
        }

        public static bool Vowel(this string s)
        {
            return Regex.IsMatch(s.ToLowerInvariant(), @"^[aiueo]\z");
            //public static bool Vowel(this string s) => Regex.IsMatch(s, @"^(?i)[aeiou]\z");
        }

        public static int Gap(int num)
        {
            var binary = Convert.ToString(num, 2);
            return binary.Substring(0, binary.LastIndexOf('1') + 1).Split('1').Max(x => x.Length);

            //return Convert.ToString(num, 2).TrimEnd('0').Split('1').Max(x => x.Length);

            //var binary = Convert.ToString(num, 2);
            //return binary.Trim('0').Split('1').Select(s => s.Length).Max();
        }

        public static int SumOfABeach(string s)
        {
            return Regex.Matches(s, "(?i)(sand|water|fish|sun)").Count;
        }

        public static string RemoveNoise(string equation)
        {
            return Regex.Replace(equation, @"[%$&\/#·@|º\\ª]", "");
        }
    }
}
