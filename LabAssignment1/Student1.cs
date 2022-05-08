using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Student1
    {
        public int Roll_no;
        public string Name;

        public void disp()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Roll No:{Roll_no}");
        }
    }

    class Test : Student1
    {
        public int marks1;
        public int marks2;

        public void disp1()
        {
            Console.WriteLine($"Marks1:{marks1}");
            Console.WriteLine($"Marks2:{marks2}");
        }
    }

    class Result : Test
    {
        public Result(string name, int roll, int m1, int m2)
        {
            this.Name = name;
            this.Roll_no = roll;
            this.marks1 = m1;
            this.marks2 = m2;
        }

        public void display()
        {
            int total = marks1 + marks2;
            Console.WriteLine($"Total:{total}");
        }
    }
}
