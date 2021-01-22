using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectoryNA21
{
    public class Employee
    {
        //Properties
        //Här utan setters vi kan alltså inte ändra värdet efter det satts
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

        //Konstruktor
        public Employee(int salary, string name)
        {
            Salary = salary;
            Name = name;
        }

        //Metod
        //Vi specialiserar betendet av ToString() metoden. Istället för default implementationen så vill vi att den här koden körs när vi anropar .ToString() på en Employee instans
        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }

    }
}
