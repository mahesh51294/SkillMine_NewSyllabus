using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class ShowEvenPosition
    {
        public void EvenPosition(int[]a)
        {
            Console.WriteLine("Enter the array elements are...");
            for(int i=0;i<a.Length;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        static void Main(string[]args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Even position elements of arrays are");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            ShowEvenPosition obj = new ShowEvenPosition();
            obj.EvenPosition(arr);
        }
    }
}
