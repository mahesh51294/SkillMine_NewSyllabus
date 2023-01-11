using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.WhileLoop
{
    class CountNumberOfDigitFromNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n > 0)
            {
                int digit = n % 10;
                count++;
                n = n / 10;
            }
            Console.WriteLine("Total Digit in Number is: " + count);
        }
    }
}

