using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public static class StringExamples
    {
        public static  void stringComp()
        {
            var str = "Prince the great";

            var result = string.Compare(str, "Prince the Great");
            Console.WriteLine("String Compare without ingorning case : "+result);

            var result2 = string.Compare(str, "Prince the great", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("String Compare without ingorning case :"+result2);

        }

        public static void stringSearch()
        {
            var str = "Prince the great";

            var rslt = str.Contains("prince");
            Console.WriteLine("String Contain operation before env case ignore."+rslt);

            rslt = str.StartsWith("prince", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("String string start with prince and env case ignore." + rslt);


            rslt = str.EndsWith("prince", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("String string end with prince and env case ignore." + rslt);

            //var result = str.Contains("prince", StringComparison.CurrentCultureIgnoreCase);
        }


        public static void decomposingUrls()
        {
            var exit = "0";

            while(exit !="1")
            {
                Console.WriteLine("Please enter an url.");
                var url = Console.ReadLine();

                var urlParts = url.Split('/');

                int i = 1;
                foreach (var urlPart in urlParts)
                {
                    var intent = new string(' ', i * 2);
                    Console.WriteLine(intent+"->" +urlPart.Replace("-", " ").Replace("www.", ""));
                    i++;
                }

                Console.WriteLine("For exit please enter 0 and for continue press any key ");
                exit = Console.ReadLine();
            }
            

        }

    }
}
