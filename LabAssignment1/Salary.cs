using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Salary
    {
        public int Basic;   //Basic salary
        public int TA;      //Travelling allowance
        public int DA = 2500;      //Dearness allowance
        public int HRA = 3000;     //House rent allowance

        public Salary(int basic, int ta)
        {
            this.Basic = basic;
            this.TA = ta;
        }

        public void calcSalary()
        {
            int basicSalary = Basic + TA + DA + HRA;
            Console.WriteLine($"Gross salary = {basicSalary}");
        }
    }
}
