using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");
            string text = Console.ReadLine();
            string[] arr = text.Split(' ');
            foreach(string word in arr)
            {
                Console.WriteLine($" \"{word}\" ");
            }

            Console.ReadKey();
        }

    }

    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many students you want?");
            int num = Convert.ToInt32(Console.ReadLine());

            Student[] std = new Student[num];
            for (int i = 0; i < num; i++)
                std[i] = new Student();

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your course name:");
                string course = Console.ReadLine();
                Console.WriteLine("Enter your date of birth:");
                string dob = Console.ReadLine();
                std[i].setStudent(i+1, name, course, dob);
            }

            Console.WriteLine("\n\nStudent Details::\n");
            for (int i = 0; i < num; i++)
                std[i].displayStudent();

            Console.ReadKey();
        }

    }

    internal class Program3
    {
        static void Main(string[] args)
        {
            Staff[] staff = new Staff[5];
            for (int i = 0; i < 5; i++)
                staff[i] = new Staff();

            staff[0].setStaff("Ram", "HOD");
            staff[1].setStaff("Sita", "Volunteer");
            staff[2].setStaff("Hari", "HOD");
            staff[3].setStaff("Gita", "Organizer");
            staff[4].setStaff("Shyam", "HOD");

            for (int j = 0; j < 5; j++)
            {
                if(staff[j].Post == "HOD")
                {
                    Console.WriteLine(staff[j].Name);
                }
            }

            Console.ReadKey();
        }

    }

    internal class Program4
    {
        static void Main(string[] args)
        {
            Swap s = new Swap();
            s.swap(5,10);
            s.swap(12.3f,14.4f);

            Console.ReadKey();
        }

    }

    internal class Program5
    {
        static void Main(string[] args)
        {
            Salary sal = new Salary(30000,2000);
            sal.calcSalary();
            Console.ReadKey();
        }

    }

    internal class Program6 //Single inheritance
    {
        static void Main(string[] args)
        {
            Table tab = new Table(13.25, 33);
            tab.material = "metal";
            tab.price = 3000;
            tab.display();
            Console.ReadKey();
        }

    }

    internal class Program7 //Multiple inheritance
    {
        static void Main(string[] args)
        {
            Salary1 s1 = new Salary1("Ram", 5000, 2000);
            s1.display();
            s1.gross_sal();
            Console.ReadKey();
        }

    }

    internal class Program8 //Multilevel inheritance
    {
        static void Main(string[] args)
        {
            Result res = new Result("Ram", 22, 25, 34);
            res.disp();
            res.disp1();
            res.display();
            Console.ReadKey();
        }

    }
}
