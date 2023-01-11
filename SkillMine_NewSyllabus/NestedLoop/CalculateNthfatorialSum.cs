using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.NestedLoop
{
    class CalculateNthfatorialSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }
                sum = sum + fact;

            }
            Console.WriteLine("Sum of all number factorial between 1 to " + n + " is: " + sum);
        }
    }
}

