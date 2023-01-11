using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.BreakContinue
{
    class NumberIsSpyOrNot
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int muldigit = 1;
            int addDigit = 0;
            while (n > 0)
            {
                int digit = n % 10;
                muldigit = muldigit * digit;
                addDigit = addDigit + digit;
                n = n / 10;

            }
            if (muldigit == addDigit)
            {
                Console.WriteLine(temp + " is Spy Number...");
            }
            else
                Console.WriteLine(temp + " is Not Spy Number...");
        }
    }
}
