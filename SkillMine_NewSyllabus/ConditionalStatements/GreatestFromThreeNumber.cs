using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.ConditionalStatements
{
    class GreatestFromThreeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd number :");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine(a + " is Greatest Number");
            else if (b > a && b > c)
                Console.WriteLine(b + " is Greatest Number");
            else
                Console.WriteLine(c + " is Greatest");



        }
    }
}

