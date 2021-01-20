namespace EmployeeDirectoryNA21
{
    //Publik synlig för alla, Internal synlig inne i den här Assemblyn (Det här programmet)
    public class Robot
    {
        //Struktur på en klass
        // 1. privata fält
        // 2. publika properties (privata properties make no sense)
        // 3. Konstruktor/Konstruktorer
        // 4. Metoder


        //privata fält
        //private enbart tillgängligt inne i den här klassen!
        private int age;

        //Publikt fält OBS! Använd property istället
        //Autoproperty som i Name nedan om du inte behöver validera eller göra något, dvs skriva kod i gettern eller settern
        //Annars property med tillhörande privat fält som i length även om vi inte skriver någon kod här just nu
         //public int Age;

        //privat fält som sätts av SetHeight(), Hämtas av GetHeight()
        //Så här gör man oftast i andra språk tex Java.
        //I C# används nästan alltid properties istället om det inte är så att det är mer komplex logik.
        //Tex att man anropar andra metoder och klasser.
        private int height;

        public int GetHeight()
        {
            return height;
        }

        public void SetHeight(int newHeight)
        {
             height = newHeight;
        }


        //Snippet: propfull
        //Bakomliggande privat fält med publikt property
        //Exakt samma funktionalitet som height, med GetHeight() och SetHeight()
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        //Snippet: prop
        //Exakt samma kod som length och height
        //Använd alltid den här syntaxen istället för publika fält!
        public string Name { get; set; }

        //Konstruktor
        //Snippet ctor
        //Det här en default konstruktor den finns även om den inte syns. Tills man skapar en annan konstuktor. Då måste man skriva ut den manuellt för att få tillgång till den.
        //public Robot()
        //{

        //}

        //Konstruktor med en parameter
        //En konstruktor har aldrig någon retur typ och heter samma sak som klassen
        //Konstruktorn körs direkt när man skapar ett ny instans av klassen med nyckelordet new
        //Tex Robot robot = new Robot("Kalle");
        //Nu måste vi alltid skicka med ett namn för att få skapa en ny Robot
        public Robot(string name)
        {
            Name = name;
        }

        //metoder
        public void Walk(int distance)
        {
            //ToDo Implement later
        } 
        
 
    }
}