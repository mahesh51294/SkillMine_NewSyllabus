using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.ForLoop
{
    class DivisibleBy3And5
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
