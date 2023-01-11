using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.BreakContinue
{
    class SumGreaterThan10Break1to20
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
                if (sum > 10)
                {
                    break;
                }
            }
        }

    }
}
