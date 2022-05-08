using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Swap
    {
        public void swap(int a, int b)
        {
            Console.WriteLine("\nBefore swap:");
            Console.WriteLine($"a={a} & b={b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swap:");
            Console.WriteLine($"a={a} & b={b}");
        }

        public void swap(float a, float b)
        {
            Console.WriteLine("\nBefore swap:");
            Console.WriteLine($"a={a} & b={b}");
            float temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swap:");
            Console.WriteLine($"a={a} & b={b}");
        }
    }
}
