using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus
{
     class ProgramStudent
    {
        static void Main(string[]args)
        {
            StudentData stu = new StudentData();
            Console.WriteLine("Enter id,name,age");
            Student s1 = new Student();
            s1.Id = Convert.ToInt32(Console.ReadLine());
            s1.name = Console.ReadLine();
            s1.age= Convert.ToInt32(Console.ReadLine());
            stu.AddStudent(s1);

            Console.WriteLine("Enter id,name,age");
            Student s2 = new Student();
            s2.Id = Convert.ToInt32(Console.ReadLine());
            s2.name = Console.ReadLine();
            s2.age = Convert.ToInt32(Console.ReadLine());
            stu.AddStudent(s2);

          //  List<Student> StudentData = stu.List();
         //   foreach(Student item in StudentData)
/*            {
                Console.WriteLine($"{item.Id}{item.name}{item.age}");
            }

            Console.Write("Enter id to remove");
            int id = Convert.ToInt32(Console.ReadLine());
            stu.RemoveStudent(id);
            
            foreach (Student item in StudentData)
            {
                Console.WriteLine($"{item.Id}{item.name}{item.age}");
            }*/

            Console.WriteLine("Enter id to modify");
            Student s = new Student();
            s.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name and age");
            s.name = Console.ReadLine();
            s.age = Convert.ToInt32(Console.ReadLine());






        }

    }
}
