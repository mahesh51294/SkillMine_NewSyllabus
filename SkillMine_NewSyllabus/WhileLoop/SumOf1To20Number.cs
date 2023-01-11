using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.WhileLoop
{
    class SumOf1To20Number
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (i <= 20)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine("sum of 1 to 20 number is: " + sum);
        }
    }
}

