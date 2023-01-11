using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Pattern
{
    class Pattern7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows?");
            int row = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (j == 4 || j == 1)

                        Console.Write("* ");
                    else if (i == 2 && j == 2 || i == 3 && j == 3)
                        Console.Write("* ");
                    else
                        Console.Write("  ");

                }
                Console.WriteLine();
            }
        }
    }
}
