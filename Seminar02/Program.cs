using System.Security.Cryptography.X509Certificates;

namespace Seminars
{
    internal class Program
    {
        static void prepareConsoleForCharacterSheet()
        {
            //Use Console.Clear() before displaying.
            //Change Console.ForegroundColor and/ or Console.BackgroundColor.
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            //Add a custom Console.Title.
            Console.Title = "Character Sheet";
        }
        public static string promptUser(string message)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();
            if (result != null)
            {
                return result;
            }
            else
            {
                return "";
            }
        }

        public static void Main(string[] args)
        {
            //variables representing the character
            //string characterName;

            //string[] statNames;
            //int[] stats;

            ////initialing the stat array(s)
            //stats = new int[7];
            //statNames = ["Agility", "Strength", "Vigour", "Perception", "Intellect", "Will", "Luck"];

            //defining a method:
            //public (or specific non-public keyword)
            //static (or leave it blank)
            //void (or a return type)
            //<nameOfMethod>
            //(arguments), in the form of: (int number, string name)
            //public static void Main([arguments]){}
            //static int calculateSecondaryStat(int stat1, int stat2)
            //{
            //    int advancedStat = stat1 + stat2;
            //    return advancedStat;
            //}


            //Console.WriteLine(calculateSecondaryStat(5, 10));
            //Console.WriteLine(calculateSecondaryStat(15, 20));
            //Console.WriteLine(calculateSecondaryStat(-5, 0));


            //prompt the user for the Name
            //Console.WriteLine("Enter Character Name: ");
            //characterName = Console.ReadLine();
            //characterName = promptUser("Enter Character Name: ");

            ////for each stat in the array, prompt the user and get the stat (between 15 and 50)
            //for (int i = 0; i < stats.Length; i++)
            //{
            //    //Console.WriteLine($"Enter Character {statNames[i]}: ");
            //    //stats[i] = Convert.ToInt32(Console.ReadLine());
            //    stats[i] = Convert.ToInt32(promptUser($"Enter Character {statNames[i]}: "));
            //    stats[i] = Math.Clamp(stats[i], 15, 50);
            //}

            ////secondary attributes
            //int Awareness;
            //int Toughness;
            //int Resolve;

            ////calculate them, using the primary attributes collected above
            ////Awareness = Agility + Perception
            ////Awareness = stats[(int)STATS.Agility] + stats[(int)STATS.Perception];
            //Awareness = CharacterSheet.calculateSecondaryStat(stats, STATS.Agility, STATS.Perception);
            ////Toughness = Strength + Vigour;
            //Toughness = CharacterSheet.calculateSecondaryStat(stats, STATS.Strength, STATS.Vigour);
            ////Resolve = Intellect + Will;
            //Resolve = CharacterSheet.calculateSecondaryStat(stats, STATS.Intellect, STATS.Will);

            CharacterSheet partyMember1;
            partyMember1 = new CharacterSheet();
            //CharacterSheet partyMember2 = new CharacterSheet();

            prepareConsoleForCharacterSheet();
            partyMember1.displayCharacterSheet();
            //displayCharacterSheet(partyMember1.CharacterName, partyMember1.Stats, partyMember1.Awareness, partyMember1.Toughness, partyMember1.Resolve);
            //displayCharacterSheet("Connor", [15, 10, 70, 14, 60, 30, 45], 10, Toughness, 100);
        }
    }
}
