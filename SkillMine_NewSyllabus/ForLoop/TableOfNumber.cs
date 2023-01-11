using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.ForLoop
{
    class TableOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number which you want table");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);

            }


        }
    }
}
