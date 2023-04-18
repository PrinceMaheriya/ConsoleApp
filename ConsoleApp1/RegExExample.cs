using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public static class RegExExample
    {
        
        const string str1 = "The shikhu is great";
        const string str2 = "the shikhu is great";

        const string CapitalLetterRegExp = @"[A-Z]\w+";
        const string PhoneNoRegExp = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
        const string ValidDate = @"[0-9]{2}\[0-9]{2}\[0-9]{4}";
        const string EmailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        public static void MatchCapitalLetterString()
        {
            Regex rgex = new Regex(CapitalLetterRegExp);
            Regex rgexIngoreCase = new Regex(CapitalLetterRegExp, RegexOptions.IgnoreCase);
            
            Console.WriteLine("Str1 has capital word:" + rgex.IsMatch(str1));
            Console.WriteLine("Str2 has capital word:" + rgex.IsMatch(str2));
            Console.WriteLine("Case Insensitive Str2 has capital word :" + rgexIngoreCase.IsMatch(str2));
        }

        public static void IsValidPhoneNumber(string phone = null)
        {
            Stopwatch sw = Stopwatch.StartNew();
            string[] phoneNumbers = new string[] { "1234567890", "+91 95 84825188", "+91 958 4825 188" };

            Regex rg = new Regex(PhoneNoRegExp);

            foreach( var ph in phoneNumbers)
            {
                var result = rg.IsMatch(ph);
                Console.WriteLine("Is "+ph +" valid : "+result);
            }
            sw.Stop();
        }

        //TODO: you may want to load the patterns supported from resource, file, settings etc.
        private static string[] m_Patterns = new string[] {
                                                            @"^[0-9]{10}$",
                                                            @"^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$",
                                                            @"^[0-9]{3}-[0-9]{4}-[0-9]{4}$",
                                                          };

        private static string MakeCombinedPattern()
        {
            return string.Join("|", m_Patterns
              .Select(item => "(" + item + ")"));
        }


        public static  void IsValidDate(string date)
        {
            if(DateTime.TryParse(date, out DateTime result))
            {
                var reverseString = GetReverseDate(date);
                Console.WriteLine("Reverse format of date."+reverseString);
            }
            else
            {
                Console.WriteLine("Please enter valid date.");
            }
        }

        private static string GetReverseDate(string date)
        {
            return Regex.Replace(date, @"^(?<mon>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})$",
                "${year}-${mon}-${day}", RegexOptions.None, TimeSpan.FromMilliseconds(1000));
        }

        public static bool IsValidEmail(string email)
        {
            var isEmailStartWithNumber = Regex.IsMatch(email, @"^\d+");

            Console.WriteLine($"Your email Id is : {email}");

            if(!isEmailStartWithNumber)
            {
                Regex reg = new Regex(EmailRegex);

                return reg.IsMatch(email);
            }
            else
            {
                return false;
            }

            

        }


    }
}
