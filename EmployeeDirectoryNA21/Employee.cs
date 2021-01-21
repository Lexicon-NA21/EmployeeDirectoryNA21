using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectoryNA21
{
    class Employee
    {
        public int Salary { get; }
        public string Name { get; }

        public SalaryLevel SalaryLevel 
        {
            get
            {
               return Salary < 15000 ? 
                             SalaryLevel.Junior : 
                             SalaryLevel.Senior ;
            }
        
        }

        public Employee(int salary, string name)
        {
            Salary = salary;
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }

    }
}
