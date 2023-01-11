using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class MinMaxFromCharacterArray
    {
        public char MinFromArray(char[] a)
        {
            char min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        public char MaxFromArray(char[] a)
        {
            char max = a[0];
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
            char[] arr = new char[6];
            Console.WriteLine("Enter the Integer Element of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }
            MinMaxFromCharacterArray m = new MinMaxFromCharacterArray();
            char minimum = m.MinFromArray(arr);
            Console.WriteLine("Minimum Character from array is: " + minimum);
            char maximum = m.MaxFromArray(arr);
            Console.WriteLine("Maximum character from array is: " + maximum);

        }
    }
}