using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class Replace0WhichDivisibleBy3
    {
        public void ReplacewithZero(int[] a)
        {


            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 3 == 0)
                {
                    a[i] = 0;
                }
            }
            Console.WriteLine("After Replacement element divisible by 3 by zero: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

        }
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter the Integer Element of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Replace0WhichDivisibleBy3 r = new Replace0WhichDivisibleBy3();
            r.ReplacewithZero(arr);





        }
    }
}
