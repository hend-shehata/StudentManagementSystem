using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    internal class StudentManager
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Instructor> Instructors { get; set; }

        public StudentManager()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            Instructors = new List<Instructor>();
        }

        public bool AddStudent(Student student)
        {
            Students.Add(student);
            return true;
        }

        public bool AddCourse(Course course)
        {
            Courses.Add(course);
            return true;
        }


        public bool AddInstructor(Instructor instructor)
        {
            Instructors.Add(instructor);
            return true;
        }

        public Student FindStudent(int studentId)
        {
            foreach (Student student in Students)
            {
                if (student.StudentId == studentId)
                {
                    return student;
                }
            }

            return null;
        }

        public Course FindCourse(int courseId)
        {
            foreach (Course course in Courses)
            {
                if (course.CourseId == courseId)
                {
                    return course;
                }
            }
            return null;
        }

        public Instructor FindInstructor(int instructorId)
        {
            foreach (Instructor instructor in Instructors)
            {
                if (instructor.InstructorId == instructorId)
                {
                    return instructor;
                }
            }

            return null;
        }


        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            Course course = FindCourse(courseId);

            if (student != null && course != null)
            {
                student.Enroll(course);
                return true;
            }

            return false;
        }


    }
    }
