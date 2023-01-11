using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.NestedLoop
{
    class KrishnmurtiNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;

                }
                sum = sum + fact;
                n = n / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine(temp + " is Krishmurti Number.....");
            }
            else
                Console.WriteLine(temp + " is Not Krishmurti Number.....");

        }
    }
}

