using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Student
    {
        public int StudentId;
        public string StudentName;
        public string CourseName;
        public string DateOfBirth;

        public void setStudent(int id, string name, string course, string dob)
        {
            this.StudentId = id;
            this.StudentName = name;
            this.CourseName = course;
            this.DateOfBirth = dob;
        }

        public void displayStudent()
        {
            Console.WriteLine("Student:");
            Console.WriteLine("\tId    : " + StudentId);
            Console.WriteLine("\tName   : " + StudentName);
            Console.WriteLine("\tCourse   : " + CourseName);
            Console.WriteLine("\tDOB   : " + DateOfBirth);
            Console.WriteLine("\n");
        }
    }
}
