using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.ConditionalStatements
{
    class SwapingOfTwoNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Sencond Number: ");
            int b = int.Parse(Console.ReadLine());
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("value of a is:  " + a);
            Console.WriteLine("value of b is:  " + b);
        }
    }
}
}
