using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class CountOddElement
    {
        public int OddCount(int[]a)
        {
            int count = 0;
            for(int i=0;i<=a.Length;i++)
            {
                if(a[i]%2!=0)
                {
                    count++;

                }
            }
            return count;
        }
         static void Main(string[]args)
        {
            Console.WriteLine("Enter size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the array elements");
            for(int i=0;i<=a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            CountOddElement obj = new CountOddElement();
            int count = obj.OddCount(a);
            Console.WriteLine("Total count of odd numbers in this arrays is" + count);
        }


    }
    
}
