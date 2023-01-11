using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.ConditionalStatements
{
    class VowelOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch == 'a' || ch == 'A') || (ch == 'e' || ch == 'E') || (ch == 'i' || ch == 'I') || (ch == 'o' || ch == 'O') || (ch == 'u' || ch == 'U'))
                Console.WriteLine(ch + " is Vowel");
            else
                Console.WriteLine(ch + " is Consonent");




        }
    }
}

