using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    internal class Course
    {
        public int  CourseId { get; set; }
        public string Title { get; set; }

        public Instructor Instructor { get; set; }
        public Course(int courseId, string title, Instructor instructor)
        {
            this.CourseId = courseId;
            this.Title = title;
            this.Instructor = instructor;
        }
        public string PrintDetails()
        {
            return $"Course Id: {CourseId}, Title: {Title}, Instructor: {Instructor.PrintDetails()}";
        }



    }
}
