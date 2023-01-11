using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Pattern
{
    class Pattern8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows?");
            int row = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (j == 5)

                        Console.Write("* ");
                    else if (i == 3 && (j == 3 || j == 4))
                        Console.Write("* ");
                    else
                        Console.Write("  ");

                }
                Console.WriteLine();
            }
        }
    }
}
