using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.ForLoop
{
    class CountOddNumber1To20
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                    // Console.WriteLine(i);
                }
            }
            Console.WriteLine("Total Odd number between 1 to 20 is: " + count);

        }
    }
}
