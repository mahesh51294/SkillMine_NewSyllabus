using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.ConditionalStatements
{
    class DayNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Day number:");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
                Console.WriteLine("its Monday");
            else if (n == 2)
                Console.WriteLine("its Tusday");
            else if (n == 3)
                Console.WriteLine("its Wensday");
            else if (n == 4)
                Console.WriteLine("its Thusday");
            else if (n == 5)
                Console.WriteLine("its Friday");
            else if (n == 6)
                Console.WriteLine("its Saturday");
            else if (n == 7)
                Console.WriteLine("its sunday");

            else
                Console.WriteLine(" invalide Day Number");

        }
    }
}

