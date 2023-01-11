using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.ForLoop
{
    class SumOfFactorOfGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number which you want table");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;

                }
            }
            Console.WriteLine("Sum of Factors is: " + sum);
        }
    }
}
