using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace StudentManagementSystem
{
    internal class Student
    {  
        int age;
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int Age
        {
            set
            {
                if (value > 15)
                {
                    age = value;
                }
            }
            get { return age; }
        }

        public List<Course> Courses { get; set; }
        public Student(int studentId, string name, int age)
        {
            this.StudentId = studentId;
            this.Name = name;
            this.Age = age;
            this.Courses = new List<Course>();
        }
       public bool Enroll(Course course)
        {

            Courses.Add(course);
            return true;
        }

        public string PrintDetails()
        {
            return $"Student Id: {StudentId}, Name: {Name}, Age: {Age}";
        }

       
    }
}
