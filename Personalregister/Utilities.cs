using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Utilities
    {
        public class RegisterEmployee()
        {
            private List<Employee> Employees = new List<Employee>();

            public void AddEmployee(string name, decimal salary)
            {
                Employees.Add(new Employee(name, salary));
            }

            public void PrintRegistry()
            {
                Console.WriteLine("\n*** Employee Registry ***");
                int i = 1;
                foreach (var employee in Employees)
                {
                    Console.WriteLine("Employee number " + i + ": " + employee);
                    i++;
                }

            }

        }

        public class Employee(string name, decimal salary)
        {
            public string Name { get; set; } = name;
            public decimal Salary { get; set; } = salary;

            public override string ToString()
            {
                return $"Name: {Name}, Salary: {Salary} kr";
            }
        }
    }
}

