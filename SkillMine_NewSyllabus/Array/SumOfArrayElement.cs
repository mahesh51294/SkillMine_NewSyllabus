using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class SumOfArrayElement
    {

        public void SumOfElement(int[] a)
        {

            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("sum of array Element is: " + sum);

        }
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter the Integer Element of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            SumOfArrayElement d = new SumOfArrayElement();
            d.SumOfElement(arr);





        }
    }
}
