using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class DisplayAlternateElementOfArray
    {
        public void AlternateElement(int[] a)
        {
            Console.WriteLine("Alternate Element Array is: ");
            for (int i = 0; i < a.Length; i = i + 2)
            {
                Console.WriteLine(a[i]);
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
            DisplayAlternateElementOfArray d = new DisplayAlternateElementOfArray();
            d.AlternateElement(arr);
        }
    }
}
