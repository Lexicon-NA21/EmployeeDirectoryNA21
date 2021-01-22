using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectoryNA21
{
    class Payroll
    {
        //private fält
        private List<Employee> payroll;

        //Konstruktor
        public Payroll()
        {
            payroll = new List<Employee>();
        }

        //Metoder
        public Employee[] GetEmployees()
        {
            return payroll.ToArray();
        }

        public void AddEmplyee(string name, int salary)
        {
            payroll.Add(new Employee(salary, name));
        }
    }
}
