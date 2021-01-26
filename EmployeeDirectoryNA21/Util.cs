using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectoryNA21
{
    //Statisk klass kan ej instansieras (med andra ord EJ : Util util = new Util())
    //Statiska klasser kan endast ha statiska medlemmar
    //Anropas med klassNamn.MetodNamn tex Util.AskForString("Hej!", new ConsoleUI())
    public static class Util
    {
        //Prompt = det vi vill skriva ut på skärmen
        //Ui hanterar utskrift
        public static string AskForString(string prompt, IUI ui)
        {
            bool success = false;
            string answer;

            //loopa tills användaren har skrivit in något
            //Än så länge ingen annan validering
            do
            {
                Console.WriteLine(prompt);
                answer = ui.GetInput();

                if (String.IsNullOrWhiteSpace(answer))
                {
                    ui.Print("You must enter something");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        public static int AskForInt(string prompt, IUI ui)
        {
            bool success = false;
            int answer;

            do
            {
                string input = AskForString(prompt, ui);
                success = int.TryParse(input, out answer);  //Om vi kan parsa inputen till en int = true annars                                                false
                if(!success)
                    ui.Print("Only numbers");


            } while (!success);

            return answer;

        }
    }
}
