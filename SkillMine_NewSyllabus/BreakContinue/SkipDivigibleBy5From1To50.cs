using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.BreakContinue
{
    class SkipDivigibleBy5From1To50
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }

    }
}
