using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void CalclatorDelegate(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            var employess = new Employee[]
            {
                new Employee{Id=1,Name="Mohamed",Salary=60000m},
                new Employee{Id=2,Name="Omar",Salary=70000m},
                new Employee{Id=3,Name="Magdy",Salary=80000m},
                new Employee{Id=4,Name="Mostafa",Salary=85000m},
                new Employee{Id=5,Name="Ali",Salary=90000m},
                new Employee{Id=6,Name="Ahmed",Salary=95000m},
            };

            //Employlees with salaries greater than 80000$
            Report report = new Report();
            report.GetEmployees(employess, e => e.Salary > 80000m);


            //Multicast Delegate
            Calclator calclator = new Calclator();

            CalclatorDelegate calclatorDelegate;
            calclatorDelegate = calclator.sum;
            calclatorDelegate += calclator.multiply;

            calclatorDelegate(3,2);
        }
    }

    public class Calclator 
    { 
        public void sum(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void multiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

    }
}
