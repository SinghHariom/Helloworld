using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello Duniya");
            Emp emp = new Emp { ID = 20, Name = "Hariom", Salary = 60 };
            Console.WriteLine($" {emp.ID} {emp.Name} {emp.Salary} ");
        }
    }
}
