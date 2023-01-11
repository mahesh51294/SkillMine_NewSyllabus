using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class ReplaceCharByAternateChar
    {
        public void ReplaceByAlternateChar(char[] a)
        {
            Console.WriteLine("After replacing character by next Alternate Character...");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'y' || a[i] == 'z' || a[i] == 'Y' || a[i] == 'Z')
                {
                    a[i] = (char)(a[i] - 24);
                }
                else
                {
                    a[i] = (char)(a[i] + 2);
                }
                Console.Write(a[i] + " ");
            }

        }

        static void Main(string[] args)
        {
            char[] arr = new char[6];
            Console.WriteLine("Enter the Character Element of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }
            ReplaceCharByAternateChar r = new ReplaceCharByAternateChar();
            r.ReplaceByAlternateChar(arr);





        }
    }
}
