using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class ReplaceNegativeWthSquareOfPrevious
    {

        public void ReplaceWithsqrOfPrevious(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {

                    a[i] = a[i - 1] * a[i - 1];
                }
            }
            Console.WriteLine();
            Console.WriteLine("After replacement Array is: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
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

            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }

            ReplaceNegativeWthSquareOfPrevious f = new ReplaceNegativeWthSquareOfPrevious();
            f.ReplaceWithsqrOfPrevious(arr);
        }
    }
}
