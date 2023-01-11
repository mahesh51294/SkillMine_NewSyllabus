using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class VowelFromArray
    {
        public void CheckVowel(char[] a)
        {
            Console.WriteLine("Vowels are.....");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'A' || a[i] == 'I' || a[i] == 'O' || a[i] == 'E' || a[i] == 'U')
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            char[] ch = new char[6];
            Console.WriteLine("Enter the character of array");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            VowelFromArray v = new VowelFromArray();
            v.CheckVowel(ch);
        }
    }
}
