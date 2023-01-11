using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.NestedLoop
{
    class DisariumNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int countDigit = 0;
            int temp = n;
            int temp2 = n;
            while (n > 0)
            {
                int digit = n % 10;
                n = n / 10;
                countDigit++;
            }
            //Console.WriteLine(countDigit);
            n = temp;
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                int power = 1;
                for (int i = 1; i <= countDigit; i++)
                {
                    power = power * digit;

                }
                sum = sum + power;
                n = n / 10;
                countDigit--;


            }
            if (temp2 == sum)
            {
                Console.WriteLine(temp2 + " is Disarium Number....");
            }
            else
                Console.WriteLine(temp2 + " is Not Disarium Number....");


        }
    }
}

