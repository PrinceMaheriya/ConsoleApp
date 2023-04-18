using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ControlStatementService
    {
        Dictionary<int, string> employee = new Dictionary<int, string>();

        public ControlStatementService()
        {
            employee.Add(1, "Prince");
            employee.Add(2, "Ram");
            employee.Add(3, "Sam");
        }

        public void IfElseStatement()
        {
            if(employee.Where(a=>a.Key == 1).Select(a=>a.Value).FirstOrDefault() == "Prince")
            {
                Console.WriteLine("If statement Works fine.");
            }

            if(employee.Where(a=>a.Key == 1).Select(a => a.Value).FirstOrDefault() == "Princde")
            {

            }
            else
            {
                Console.WriteLine("Else statement printed successfully.");
            }
        }

        public void switchStatement(category ctgy)
        {
            switch(ctgy)
            {
                case category.Permanent:
                    Console.WriteLine("Permanent Employer.");
                    break;
                case category.PartTime:
                    Console.WriteLine("Part Time Employer.");
                    break;
                 default:

                    Console.Write("Default statement works fine.");
                    break;
            }
        }

        public void forLoopStatement()
        {
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        public void whileStatement()
        {
            var userinput = "Yes";

            while (userinput.ToUpper() != "EXIT")
            {
                Console.WriteLine("Please enter exit to get rid of this loop");
                userinput =  Console.ReadLine();
            }
        }

        public void goToStatement()
        {
            ineligible:
            Console.WriteLine("You are not eligible to vote.");

            var age = string.Empty;
            int n;

            while(int.TryParse(age, out n))
            {
                Console.WriteLine("Enter your age in number:");
                age = Console.ReadLine();
            }
            

            if(Convert.ToInt16(age) < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible");
            }

        }

        public enum category
        {
            Permanent,
            PartTime,
            Weekly
        }

    }
}
