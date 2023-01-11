using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.NestedLoop
{
    class PrimeOfavgBtween1To20
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int primeCount = 0;
            for (int i = 1; i <= 20; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }

                }
                if (flag == true)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                    primeCount++;
                }
            }
            double avg = (sum / primeCount);
            Console.WriteLine("Avarage of Prime Number between 1 to 20 is: " + avg);
        }
    }
}

