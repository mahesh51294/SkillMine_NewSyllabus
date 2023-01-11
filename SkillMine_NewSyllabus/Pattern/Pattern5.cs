using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Pattern
{
    class Pattern5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows?");
            int row = int.Parse(Console.ReadLine());
            int k = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(k + " ");
                    k++;
                    //  Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
