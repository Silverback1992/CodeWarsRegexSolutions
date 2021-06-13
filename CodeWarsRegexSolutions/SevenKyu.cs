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

        public static string Remove(string s)
        {
            return String.Join(" ", s.Split(' ').Select(x => $"{Regex.Match(x, "^!+").Value}{x.Replace("!", "")}"));
        }

        public static String IsItANum(string str)
        {
            string nums = Regex.Replace(str, @"\D*", "");
            return nums.Length == 11 && nums[0] == '0' ? nums : "Not a phone number";

            //var phone = Regex.Replace(str, @"\D", "");
            //return Regex.IsMatch(phone, @"^0\d{10}$") ? phone : "Not a phone number";
        }

        public static bool IpValidator(string ip)
        {
            int value;
            return ip.Split('.').Where(x => int.TryParse(x, out value) && (0 <= value) && (255 >= value) && !x.Contains(" ")).Count() == 4;
        }

        public static string CreateSequence(Regex regex)
        {
            return null;
        }

        public static string ShortForm(string str)
        {
            var m = Regex.Match(str, @"^(\w?)(.*)(\w$)");
            return $"{m.Groups[1].Value}{Regex.Replace(m.Groups[2].Value, "(?i)[aiueo]", "")}{m.Groups[3].Value}";
            //return Regex.Replace(str,@"(?!^)[aeiouAEIOU](?!$)","");
        }

        public static bool IsHex(string hex)
        {
            return Regex.IsMatch(hex, "^(?i)[a-f00-9]{3}$|^(?i)[a-f00-9]{6}$");
            //return Regex.IsMatch(hex, @"^(?i)([a-f\d]{3}){1,2}$");
        }

        public static bool Double_check(string strng)
        {
            int nextIdx = 0;

            return strng.ToLowerInvariant().Any(c =>
            {
                nextIdx++;
                return strng.ElementAtOrDefault(nextIdx) == c;
            });

            //return Regex.IsMatch(s,@"(?i)(.)\1");
        }

        public static bool HexNumber(this string s)
        {
            return Regex.IsMatch(Regex.Replace(s, "^0x", ""), @"^(?i)[a-f0-9]+\z");
            //return Regex.IsMatch(s, @"^(0x)?[A-Fa-f\d]+\z");
        }

        public static int? ToCents(this string price)
        {
            var m = Regex.Match(price, @"^\$(\d+)\.(\d{2})\z");
            return m.Success ? Int32.Parse($"{m.Groups[1]}{m.Groups[2]}") : (int?)null;
        }
    }
}
