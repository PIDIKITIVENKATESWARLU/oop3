using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class student
    {
        public void greet()
        {
            Console.WriteLine(" welcome to oops");
        }
        public void add()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("addition of two numbers {0}", c);
        }
        int sid;
        string sname;
        string sclg;
        public void venky()
        {
            Console.WriteLine("enter the student id ");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the student name");
            string sname = Console.ReadLine();
            Console.WriteLine("enter the student college name ");
            string sclg = Console.ReadLine();
            Console.WriteLine("student id is {0}", sid);
            Console.WriteLine("student name is {0}", sname);
            Console.WriteLine("student college name is {0}", sclg);

        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.greet();
            s.add();
            s.add();
            s.venky();
            student v = new student();
            v.add();
            v.venky();
            Console.WriteLine("venkey");

            Console.ReadLine();
        }
    }
}
