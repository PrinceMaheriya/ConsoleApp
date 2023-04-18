using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// The string is Palandrom
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //var result = IsPalandrom("aaraa");

            //Console.WriteLine($"The string is Palandrom : {result}");

            //OTPService();
            ScoreService();

            StringExamples.decomposingUrls();

            string[] emails = new string[] { "!prince@gmail.com", "princegmail.com", "prince@tech", "88prince@gmail.com", "prince@gmail.com" };

            foreach(var email in emails)
            {
               var IsValidEmail=  RegExExample.IsValidEmail(email);
                Console.WriteLine("Your email is " + (IsValidEmail ? "vlaid" : "invalid"));
            }

            RegExExample.IsValidDate("01/02/2020");

            RegExExample.MatchCapitalLetterString();

            RegExExample.IsValidPhoneNumber();


            StackQueue.LastInFirstOut();

            StackQueue.LastInLastOut();


            FilesExamples.CreateTextFile();

            StringExamples.stringComp();

            StringExamples.stringSearch();

            Program ll = new Program();

            Console.WriteLine($"Current C# version : {ll.CurrentVersion} Memory allocation before execution start :{GC.GetTotalMemory(false)}");

            OperatingSystem thisOS = Environment.OSVersion;

            Console.WriteLine($"Platform : {thisOS.Platform} Version: {thisOS.VersionString}");

            Console.ReadLine();

            callControlStatement();

            callFunctionExamples();

            callReportService();

            callArrayFunctions();

            Console.WriteLine($"Memory allocation after all function run successfully. {GC.GetTotalMemory(false)}");

            Console.ReadLine();

        }

        public static void callFunctionExamples()
        {
            FunctionExample fun = new FunctionExample();

            var name = "Ram";
            fun.refExample(ref name);
            Console.WriteLine(name);

            string employeeName;
            fun.outExample(out employeeName);
            Console.WriteLine(employeeName);
        }

        public static void callControlStatement()
        {
            ControlStatementService csservice = new ControlStatementService();

            csservice.IfElseStatement();
            csservice.switchStatement(ControlStatementService.category.Weekly);
            csservice.forLoopStatement();
            csservice.whileStatement();
        }

        public static void callReportService()
        {
            GenrateReport report = new GenrateReport("Prince the great");

            report.GeneratePDF();
            report.GenerateExcel();
            report.GenerateWordDoc();
        }

        public static void callArrayFunctions()
        {
            ArrayExample arryExmpl = new ArrayExample();

            arryExmpl.ArrayExp();
        }

        /// <summary>
        /// This function  used to find out the string is palandrom or not
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPalandrom(string str)
        {
                var result = CharToString(str);
                return str == result; 
        }

        /// <summary>
        /// This function convert the chars into string 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string CharToString(string str)
        {
            var str2 = str.Reverse().ToList();
            return new String(str2.ToArray());
        }


        public static void OTPService()
        {
            Console.WriteLine("Please enter your mobile number.");

            var mobileNumber = Console.ReadLine();


            OTPHelper otpService = new OTPHelper(Convert.ToInt64(mobileNumber));

            var otp = otpService.SendOTP();

            var cnt = 0;

            while (cnt != 1)
            {
                Console.WriteLine("Please Enter OTP.");

                var userOTP = Console.ReadLine();

                if (otp == userOTP)
                    cnt = 1;
                else if (userOTP == "2")
                {
                    otp = otpService.SendOTP();
                }
                else
                {
                    Console.WriteLine("Invalid OTP please enter again or press 2 to resend otp.");
                }
            }
        }

        public string CurrentVersion
        {
            get
            {
               return System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
            }
        }

        public static void ScoreService()
        {
            List<int> lstOfInteger = new List<int>();

            lstOfInteger.Add(23);
            lstOfInteger.Add(33);
            lstOfInteger.Add(44);
            lstOfInteger.Add(55);
            lstOfInteger.Add(66);

            Console.WriteLine("Highest Number:" + lstOfInteger.Max());
            Console.WriteLine("Lowest Number:" + lstOfInteger.Min());
            Console.WriteLine("Sum of the Numbers:" + lstOfInteger.Sum());
            Console.WriteLine("Average of the Numbers:" + lstOfInteger.Average());
        }
    }
}
