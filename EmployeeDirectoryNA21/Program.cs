using System;

namespace EmployeeDirectoryNA21
{
    class Program
    {
        static Payroll payroll = new Payroll();
        static ConsoleUI ui = new ConsoleUI();

        static void Main(string[] args)
        {
            SeedData();

            do
            {
                ShowMainMeny();
                UserAction();

            } while (true);
        }

        private static void UserAction()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    PrintEmployee();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    ui.Print("Wrong input");
                    break;
            }
        }

        private static void AddEmployee()
        {
            do
            {
                ui.Print("Add a new Employee, Q for exit");
                string name = Util.AskForString("Name: ", ui);
                if (name.Equals("Q")) break;
                int salary = Util.AskForInt("Salary: ", ui);
                payroll.AddEmplyee(name, salary);

            } while (true);
        }

        private static void ShowMainMeny()
        {
            ui.Print("1. add employee");
            ui.Print("2. print employees");
            ui.Print("3. Quit");
        }

        private static void PrintEmployee()
        {
            Employee[] employees = payroll.GetEmployees();

            foreach (Employee employee in employees)
            {
                ui.Print(employee);
            }
        }

        private static void SeedData()
        {
            payroll.AddEmplyee("Kalle", 10000);
            payroll.AddEmplyee("Anna", 20000);
            payroll.AddEmplyee("Lisa", 30000);
        }
    }
}
