using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class FrequencyOfElement
    {
        public void FindFrequency(int[] a, int n)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    count++;
                }
            }
            Console.WriteLine("Frequency of " + n + " is: " + count);
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
            Console.WriteLine();
            Console.WriteLine("Enter the Element Which you find the Frequency..");
            int n = int.Parse(Console.ReadLine());
            FrequencyOfElement f = new FrequencyOfElement();
            f.FindFrequency(arr, n);

        }
    }
}
