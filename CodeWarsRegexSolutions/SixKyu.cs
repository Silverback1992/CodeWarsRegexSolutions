using System;
using System.Collections.Generic;
using System.Globalization;
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
            var words = str.Split(new char[] { '-', '_' });
            return words[0] + String.Join("", words.Skip(1).Select(x => char.ToUpper(x[0]) + x.Substring(1)));
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

        public static string ExtractFileName(string dirtFileName)
        {
            return Regex.Match(dirtFileName, @"^[0-9]+_(.+)\.").Groups[1].Value;
        }

        public static string validator(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?i)[\da-z]{4,19}$") ? "VALID" : "INVALID";
        }

        public static string[] CleverSplit(string s)
        {
            var wordsList = new List<string>();
            var words = s.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains('[') && words[i].Contains(']'))
                    wordsList.Add(words[i]);
                else if (words[i].Contains('['))
                {
                    sb.Append($"{words[i]} ");
                    i++;

                    while (!words[i].Contains(']'))
                    {
                        sb.Append($"{words[i]} ");
                        i++;
                    }

                    sb.Append($"{words[i]} ");

                    wordsList.Add(sb.ToString().TrimEnd());
                    sb.Clear();
                }
                else
                    wordsList.Add(words[i]);
            }

            return wordsList.ToArray();
        }

        public static String[] CountRobots(String[] a)
        {
            string pattern = @"(?i)[a-z][\|\}\;\&\#\[\]\/\>\<\(\)\*]{2}0[\|\}\;\&\#\[\]\/\>\<\(\)\*]{2}0[\|\}\;\&\#\[\]\/\>\<\(\)\*]{2}(?i)[a-z]";
            string lowerX;
            int automatikCount = 0;
            int mechanikCount = 0;
            
            Array.ForEach(a, x =>
            {
                lowerX = x.ToLowerInvariant();

                if (lowerX.Contains("automatik"))
                    automatikCount += Regex.Matches(x, pattern).Count;

                if (lowerX.Contains("mechanik"))
                    mechanikCount += Regex.Matches(x, pattern).Count;
            });
            
            return new string[2] { $"{automatikCount} robots functioning automatik", $"{mechanikCount} robots dancing mechanik" };
        }

        public static string Ermahgerd(string text)
        {
            var toUpperAndER = Regex.Replace(text.ToUpper(), "[AIUEO]", x => "ER");
            var removedoulbeER = Regex.Replace(toUpperAndER, "ERER|ERH", x => "ER");
            var myToMAH = Regex.Replace(removedoulbeER, "MY", x => "MAH");
            var removeDuplicateRR = Regex.Replace(myToMAH, "RR", x => "R");
            var removeLastERIfLongerThan4 = removeDuplicateRR.Split(' ').Select(x =>
            {
                if (x.Length > 4 && Regex.IsMatch(x, "ER[^A-Z]*$"))
                    return x.Remove(x.LastIndexOf("ER"), 2);

                return x;
            });
            return String.Join(" ", removeLastERIfLongerThan4);

            //text = text.ToUpper();
            //text = Regex.Replace(text, "[AEIOU]", "ER");
            //text = Regex.Replace(text, "ERER|ERH", "ER");
            //text = Regex.Replace(text, "MY", "MAH");
            //text = Regex.Replace(text, "RR", "R");
            //text = Regex.Replace(text, @"\b(\w{4,})ER\b", "$1");
            //return text;
        }

        public static int? ToSeconds(this string time)
        {
            //Works in C# 9
            //var m = Regex.Match(time, @"^(\d\d):([0-5][0-9]):([0-5][0-9])$");
            //return m.Success ? int.Parse(m.Groups[1].Value) * 3600 + int.Parse(m.Groups[2].Value) * 60 + int.Parse(m.Groups[3].Value) : null;

            var m = Regex.Match(time, @"^(\d\d):([0-5][0-9]):([0-5][0-9])$");
            int? result = null;

            if (m.Success)
            {
                result = int.Parse(m.Groups[1].Value) * 3600 + int.Parse(m.Groups[2].Value) * 60 + int.Parse(m.Groups[3].Value);
            }

            return result;
        }

        public static string NumberFormat(int number)
        {
            return number.ToString("N0", CultureInfo.InvariantCulture);
        }

        public static string DecipherThis(string s)
        {
            StringBuilder sb = new StringBuilder();
            var words = Regex.Replace(s, @"\d+", x => ((char)(int.Parse(x.Value))).ToString());
            return String.Join(" ", words.Split(' ').Select(x => 
            {
                if(x.Length >= 2)
                {
                    sb.Clear();
                    sb.Append(x);
                    char temp = sb[x.Length - 1];
                    sb[x.Length - 1] = sb[1];
                    sb[1] = temp;
                    return sb.ToString();
                }

                return x;
            }));
        }

        public static string EncryptThis(string input)
        {
            StringBuilder sb = new StringBuilder();

            return String.Join(" ", input.Split(' ').Select(x =>
            {
                sb.Clear();

                if (String.IsNullOrEmpty(x))
                    return "";
                else if (x.Length == 1)
                    return ((int)x[0]).ToString();
                else if(x.Length == 2)
                {
                    sb.Append((int)x[0]);
                    sb.Append(x[1]);
                    return sb.ToString();
                }
                else
                {
                    sb.Append(x);
                    char temp = sb[x.Length - 1];
                    sb[x.Length - 1] = sb[1];
                    sb[1] = temp;
                    sb.Remove(0, 1);
                    sb.Insert(0, ((int)x[0]).ToString());
                    return sb.ToString();
                }
            }));
        }
    }
}
