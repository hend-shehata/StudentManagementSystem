using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    internal class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public Instructor(int id , string name , string specilization)
        {
            this.InstructorId = id;
            this .Name = name;
            this.Specialization = specilization;
        }

        public string PrintDetails()
        {
            return $"Instructor Id: {InstructorId}, Name: {Name}, Specialization: {Specialization}";
        }



    }
}
