namespace Seminars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //variables representing the character
            string characterName;
            int Agility;
            int Strength;
            int Vigour;
            int Perception;
            int Intellect;
            int Will;

            //prompt the user for the Name
            Console.WriteLine("Enter Character Name: ");
            characterName = Console.ReadLine();

            //prompt the user for the character stats (Agility)
            Console.WriteLine("Enter Character Agility: ");
            Agility = Convert.ToInt32(Console.ReadLine());
            Agility = Math.Clamp(Agility, 5, 50);

            //prompt the user for the character stats (Strength)
            Console.WriteLine("Enter Character Strength: ");
            Strength = Convert.ToInt32(Console.ReadLine());
            Strength = Math.Clamp(Strength, 5, 50);

            //prompt the user for the character stats (Vigour)
            Console.WriteLine("Enter Character Vigour: ");
            Vigour = Convert.ToInt32(Console.ReadLine());
            Vigour = Math.Clamp(Vigour, 5, 50);

            //prompt the user for the character stats (Perception)
            Console.WriteLine("Enter Character Perception: ");
            Perception = Convert.ToInt32(Console.ReadLine());
            Perception = Math.Clamp(Perception, 5, 50);

            //prompt the user for the character stats (Intellect)
            Console.WriteLine("Enter Character Intellect: ");
            Intellect = Convert.ToInt32(Console.ReadLine());
            Intellect = Math.Clamp(Intellect, 5, 50);

            //prompt the user for the character stats (Will)
            Console.WriteLine("Enter Character Will: ");
            Will = Convert.ToInt32(Console.ReadLine());
            Will = Math.Clamp(Will, 5, 50);

            //secondary attributes
            int Awareness;
            int Toughness;
            int Resolve;

            //calculate them, using the primary attributes collected above
            Awareness = Agility + Perception;
            Toughness = Strength + Vigour;
            Resolve = Intellect + Will;


            //    Use Console.Clear() before displaying.
            //Change Console.ForegroundColor and/ or Console.BackgroundColor.
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            //Add a custom Console.Title.
            Console.Title = "Character Sheet: " + characterName;

            //Display nicely formatted output(extra \n or multiple Console.WriteLine).
            //Create ASCII dividers(dashed lines) to separate the CharacterName, Primary Attributes and Secondary Attributes.
            //formatted strings because im fancy like that
            Console.WriteLine("\n{0}", characterName);
            Console.WriteLine("---------------------------");
            Console.WriteLine("AGI: {0,2:D2} | STR: {1,2:D2}", Agility, Strength);
            Console.WriteLine("VIG: {0,2:D2} | PER: {1,2:D2}", Vigour, Perception);
            Console.WriteLine("INT: {0,2:D2} | WIL: {1,2:D2}", Intellect, Will);
            Console.WriteLine("---------------------------");
            //these can hit 100, but since theres no second column to worry about, no min length required
            Console.WriteLine("AWARENESS: {0,3}", Awareness);
            Console.WriteLine("TOUGHNESS: {0,3}", Toughness);
            Console.WriteLine("  RESOLVE: {0,3}", Resolve);
            Console.WriteLine("---------------------------");


        }
    }
}
