using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Furniture
    {
        public string material;
        public int price;

        public void disp()
        {
            Console.WriteLine($"\nMaterial:{material}");
            Console.WriteLine($"Price:{price}");
        }
    }

    class Table : Furniture
    {
        public double height;
        public double surface_area;

        public Table(double height, double area)
        {
            this.height = height;
            this.surface_area = area;
        }

        public void display()
        {
            disp();
            Console.WriteLine($"Height:{height} m");
            Console.WriteLine($"Area:{surface_area} m^2");
        }
    }
}
