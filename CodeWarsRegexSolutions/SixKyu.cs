using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsRegexSolutions
{
    public static class SixKyu
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
            //return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x=>x.ToString()).ToArray());
        }

        public static string ToCamelCase(string str)
        {
            return "";
        }

        public static int CountSmileys(string[] smileys)
        {
            return smileys.Count(x => Regex.IsMatch(x, "[:;][-~]?[)D]"));
        }

        public static bool is_valid_IP(string ipAddres)
        {
            int value;
            return ipAddres.Split('.').Where(x => int.TryParse(x, out value) && (0 <= value) && (255 >= value) && !x.Contains(" ") && x.Length == value.ToString().Length).Count() == 4;
        }

        public static bool ValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\(\d\d\d\) \d\d\d-\d\d\d\d$");
            //return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3}-\d{4}\z");
        }
    }
}
