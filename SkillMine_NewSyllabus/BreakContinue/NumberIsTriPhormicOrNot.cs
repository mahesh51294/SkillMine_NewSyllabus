using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.BreakContinue
{
    class NumberIsTriPhormicOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numer");
            int n = int.Parse(Console.ReadLine());
            int mulnum = 1;
            for (int i = 1; i <= 3; i++)
            {
                mulnum = mulnum * n;
            }
            // Console.WriteLine(mulnum);
            int digit = 0;
            while (mulnum > 0)
            {
                digit = mulnum % 10;
                break;
            }
            // Console.WriteLine("Digit is:" + digit);
            if (digit == n)
            {
                Console.WriteLine(n + " is TriPhormic Number");
            }

            else
                Console.WriteLine(n + " is Not TriPhormic Number");

        }
    }
}
