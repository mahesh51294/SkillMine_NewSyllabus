using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Pattern
{
    class Pattern4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows?");
            int row = int.Parse(Console.ReadLine());
            for (int i = row; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    // Console.Write("* ");
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
