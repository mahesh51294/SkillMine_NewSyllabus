using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus
{
  public class Student
    {
        public int Id { get; set; }
        public string name { get; set; }

        public int age { get; set; }



    }

    public class StudentData
    {
        private List<Student> StudentList = null;
        public StudentData()
        {
            StudentList = new List<Student>();
        }

        public void AddStudent(Student stu)
        {
            StudentList.Add(stu);
        }

        public void UpdateStudent(Student stu)
        {
           // Student s1 = new Student();
            foreach(Student item in StudentList)
            {
                if(item.Id==stu.Id)
                {
                    //s1 = item;
                    item.name = stu.name;
                    item.age = stu.age;
                    break;
                }
            }
        }


        public void RemoveStudent(int id)
        {
            foreach(Student item in StudentList)
            {
                if (item.Id == id) 
                {
                    StudentList.Remove(item);
                }
            }
        }

      //public void CompareStudent(int n)
        /*{
            foreach(Student item in StudentList)
            {
                if (item.Marks > n)
                    StudentList.Add(item);
            }
            return StudentList;*///
        
       /* public List<Student> List()
        {
            return StudentList;
        }*/
    }
}
