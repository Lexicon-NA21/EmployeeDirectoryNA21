using System;

namespace EmployeeDirectoryNA21
{
    class Program
    {
        //Instansierar en payroll och ett ui
        //Scoopade till hela klassen
        static Payroll payroll = new Payroll();
        static ConsoleUI ui = new ConsoleUI();

        //Programmets startpunkt
        //Får bara finnas EN!
        static void Main(string[] args)
        {
            //Skapar lite dummy data
            SeedData();

            //ProgramLoop körs till användaren väljer att avsluta
            do
            {
                ShowMainMeny();
                UserAction();

            } while (true);
        }

        private static void UserAction()
        {
            //Tar ett värde från användaren
            //Testar olika case tex användaren skriver in "1" då kör vi AddEmployee(). 
            //Om vi inte träffar något case körs default koden
            switch (Console.ReadLine())
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    PrintEmployee();
                    break;
                case "3":
                    //Avslutar programmet
                    Environment.Exit(0);
                    break;
                default:
                    ui.Print("Wrong input");
                    break;
            }
        }

        private static void AddEmployee()
        {
            //Loopar tills användaren trycker "Q"
            do
            {
                ui.Print("Add a new Employee, Q for exit");
                string name = Util.AskForString("Name: ", ui);  //Säkerställer att vi får en input som inte är tom
                if (name.Equals("Q")) break;                    //Hoppar ur loopen och återgår till ProgramLoopen
                int salary = Util.AskForInt("Salary: ", ui);    //Säkerställer att vi får tillbaks en int 
                payroll.AddEmplyee(name, salary);               //Skapar en ny instans av Employee och lägger till                                                 den i Payroll

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
            //Hämtar alla Employees från PayRoll
            Employee[] employees = payroll.GetEmployees();

            foreach (Employee employee in employees)
            {
                //Overiden på ToString() som vi skrev i Employee klassen körs
                //Console.WriteLine() kör automatiskt ToString() metoden
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
