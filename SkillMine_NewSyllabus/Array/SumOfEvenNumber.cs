using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class SumOfEvenNumber
    {
        public int EvenSum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array.. ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the  Array Element ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            SumOfEvenNumber s = new SumOfEvenNumber();
            int result = s.EvenSum(a);
            Console.WriteLine("Even Element sum is: " + result);
        }
    }
}
