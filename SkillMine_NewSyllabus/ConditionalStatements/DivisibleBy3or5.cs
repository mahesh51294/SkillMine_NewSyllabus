using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.ConditionalStatements
{
    class DivisibleBy3or5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            if (n % 3 == 0 && n % 9 == 0)
                Console.WriteLine(n + " is divisible by 3 and 9");
            else
                Console.WriteLine(n + " is  Not divisible by 3 and 9");

        }
    }
}
}
