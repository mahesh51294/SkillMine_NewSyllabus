using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.SwitchCase
{
    class SwitchVowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character...");
            char c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine(c + " is vowel");
                    break;
                default:
                    if (c >= 'a' && c <= 'z')
                        Console.WriteLine(c + " is Consonent");
                    else
                        Console.WriteLine(c + " invalide character");

                    break;

            }
        }
    }
}
