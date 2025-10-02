namespace Seminars
{
    internal class Program
    {
        enum STATS
        {
            Agility,
            Strength,
            Vigour,
            Perception,
            Intellect,
            Will,
            Luck
        }

        static void Main(string[] args)
        {
            //variables representing the character
            string characterName;

            string[] statNames;
            int[] stats;

            //initialing the stat array(s)
            stats = new int[7];
            statNames = ["Agility", "Strength", "Vigour", "Perception", "Intellect", "Will", "Luck"];

            //prompt the user for the Name
            Console.WriteLine("Enter Character Name: ");
            characterName = Console.ReadLine();

            //for each stat in the array, prompt the user and get the stat (between 15 and 50)
            for (int i = 0; i < stats.Length; i++)
            {
                Console.WriteLine($"Enter Character {statNames[i]}: ");
                stats[i] = Convert.ToInt32(Console.ReadLine());
                stats[i] = Math.Clamp(stats[i], 15, 50);
            }

            //secondary attributes
            int Awareness;
            int Toughness;
            int Resolve;

            //calculate them, using the primary attributes collected above
            //Awareness = Agility + Perception
            Awareness = stats[(int)STATS.Agility] + stats[(int)STATS.Perception];
            //Toughness = Strength + Vigour;
            Toughness = stats[(int)STATS.Strength] + stats[(int)STATS.Vigour];
            //Resolve = Intellect + Will;
            Resolve = stats[(int)STATS.Intellect] + stats[(int)STATS.Will];


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
            Console.WriteLine("AGI: {0,2:D2} | STR: {1,2:D2}", stats[(int)STATS.Agility], stats[(int)STATS.Strength]);
            Console.WriteLine("VIG: {0,2:D2} | PER: {1,2:D2}", stats[(int)STATS.Vigour], stats[(int)STATS.Perception]);
            Console.WriteLine("INT: {0,2:D2} | WIL: {1,2:D2}", stats[(int)STATS.Intellect], stats[(int)STATS.Will]);
            Console.WriteLine("LUC: {0,2:D2}", stats[(int)STATS.Luck]);
            Console.WriteLine("---------------------------");
            //these can hit 100, but since theres no second column to worry about, no min length required
            Console.WriteLine("AWARENESS: {0,3}", Awareness);
            Console.WriteLine("TOUGHNESS: {0,3}", Toughness);
            Console.WriteLine("  RESOLVE: {0,3}", Resolve);
            Console.WriteLine("---------------------------");


        }
    }
}
