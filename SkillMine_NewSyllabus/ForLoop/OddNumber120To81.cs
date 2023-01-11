using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.ForLoop
{
    class OddNumber120To81
    {
        static void Main(string[] args)
        {

            for (int i = 120; i >= 81; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }


            }

        }
    }
}
