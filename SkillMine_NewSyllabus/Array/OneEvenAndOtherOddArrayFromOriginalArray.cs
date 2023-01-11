using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class OneEvenAndOtherOddArrayFromOriginalArray
    {
        public void EvenArray(int[] a)
        {
            Console.WriteLine("Even array is....");
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] even = new int[count];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even[j] = a[i];
                    j++;
                }
            }
            for (int i = 0; i < even.Length; i++)
            {
                Console.Write(even[i] + " ");
            }
        }
        public void OddArray(int[] a)
        {
            Console.WriteLine();
            Console.WriteLine("Odd array is....");
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }
            int[] odd = new int[count];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    odd[j] = a[i];
                    j++;
                }
            }
            for (int i = 0; i < odd.Length; i++)
            {
                Console.Write(odd[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[9];
            Console.WriteLine("Enter the Integer Element of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            OneEvenAndOtherOddArrayFromOriginalArray o = new OneEvenAndOtherOddArrayFromOriginalArray();
            o.EvenArray(arr);
            o.OddArray(arr);
        }
    }
}
