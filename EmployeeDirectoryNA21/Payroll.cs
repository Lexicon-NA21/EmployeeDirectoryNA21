using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectoryNA21
{
    class Payroll
    {
        private List<Employee> payroll;

        public Payroll()
        {
            payroll = new List<Employee>();
        }

        public Employee[] GetEmployees()
        {
            return payroll.ToArray();
        }

        internal void AddEmplyee(string name, int salary)
        {
            payroll.Add(new Employee(salary, name));
        }
    }
}
