using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    public interface Gross
    {
        void gross_sal();
    }

    public class Employee
    {
        public string name;
        public int basic_sal;

        public void disp()
        {
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Base salary:{basic_sal}");
        }
    }

    public class Salary1 : Employee, Gross 
    {
        int ta = 2100;
        int da = 2500;
        int hra;

        public Salary1(string name, int basic, int hra)
        {
            this.name = name;
            this.basic_sal = basic;
            this.hra = hra;
        }

        public void display()
        {
            disp();
            Console.WriteLine($"HRA is:{hra}");
        }
        public void gross_sal()
        {
            int gross_sal = basic_sal + ta + da + hra;
            Console.WriteLine($"TA of employee:{ta}");
            Console.WriteLine($"DA of employee:{da}");
            Console.WriteLine($"Gross salary of employee:{gross_sal}");
        }

    }
}
