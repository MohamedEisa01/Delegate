using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Report
    {
        public delegate bool IsLigable(Employee e);
        public void GetEmployees(Employee[] employees, IsLigable isLigable)
        {
            foreach (var emp in employees)
            {
                if (isLigable(emp))
                {
                    Console.WriteLine($"Id : {emp.Id}, Name : {emp.Name}, Salary : {emp.Salary}");
                }

            }
            Console.WriteLine("\n\n");
        }
    }
}
