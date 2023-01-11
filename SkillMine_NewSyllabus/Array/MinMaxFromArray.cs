using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class MinMaxFromArray
    {
        public int MinFromArray(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        public int MaxFromArray(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter the Integer Element of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            MinMaxFromArray m = new MinMaxFromArray();
            int minimum = m.MinFromArray(arr);
            Console.WriteLine("Minimum value from array is: " + minimum);
            int maximum = m.MaxFromArray(arr);
            Console.WriteLine("Maximum value from array is: " + maximum);


        }
    }
}
