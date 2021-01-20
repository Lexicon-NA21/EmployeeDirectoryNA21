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

        //metoder
    }
}