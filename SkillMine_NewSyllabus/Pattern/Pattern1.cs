using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Pattern
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows?");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
