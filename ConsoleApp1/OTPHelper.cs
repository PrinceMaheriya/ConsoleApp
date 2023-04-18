using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class OTPHelper
    {
        private const string APIKey = "NGIzNjc2MzEzMjc1NDk1MDRlNzA0ZDQzMzY3MzMwNzY";
        private const string APIURL = "https://api.textlocal.in/send/";

        private long _mobileNumber;
        private string opt = string.Empty;


        public OTPHelper( long mobileNumber)
        {
            _mobileNumber = mobileNumber;
        }

        private void GenerateOTP()
        {
            char[] charArray = "123456789".ToCharArray();


            Random strRandom = new Random();

            for(int i=0; i<4; i++)
            {
                //Added to make sure that the character is not repeat
                int pos = strRandom.Next(1, charArray.Length);

                if (!opt.Contains(charArray.GetValue(pos).ToString()))
                    opt += charArray.GetValue(pos);
            }

        }

        public string SendOTP()
        {
            string result;
            try
            {
                GenerateOTP();

                string destinationaddress = "91" + _mobileNumber;
                string message = "Your OTP is " + opt + "(Send by R.R.Research and development founder is Ramesh Chandra)";
                //string message1 = HttpUtility.UrlEncode(message);
                
                // using System.Net;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                using (var wb = new WebClient())
                {
                   

                    NameValueCollection values = new NameValueCollection()
                   {
            {"username" , "princemaheriya1995@gmail.com"},
            {"hash" , APIKey},
            {"sender" , "sender"},
            {"numbers" , destinationaddress},
            {"message" , opt} 
            };
                    byte[] response = wb.UploadValues("https://api.txtlocal.com/send/", "GET", values);

                    result = System.Text.Encoding.UTF8.GetString(response);
                }


                return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine("SendOTP Failed : ", ex.Message);
                return string.Empty;
            }
        }

        public static string GetResponse(string smsURL)
        {
            try
            {
                WebClient objWebClient = new WebClient();
                System.IO.StreamReader reader = new System.IO.StreamReader(objWebClient.OpenRead(smsURL));
                string ResultHTML = reader.ReadToEnd();
                return ResultHTML;
            }
            catch (Exception)
            {
                return "Fail";
            }
        }
    }
}
