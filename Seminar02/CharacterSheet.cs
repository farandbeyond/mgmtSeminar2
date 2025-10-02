using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    public enum STATS
    {
        Agility,
        Strength,
        Vigour,
        Perception,
        Intellect,
        Will,
        Luck
    }
    
    public class CharacterSheet
    {
        //name of character
        public string CharacterName;
        //stats of character
        public string[] StatNames;
        public int[] Stats;
        //advanced stats of character
        public int Awareness;
        public int Toughness;
        public int Resolve;

        public CharacterSheet()
        {
            CharacterName = Program.promptUser("Enter Character Name: ");

            Stats = new int[7];
            StatNames = ["Agility", "Strength", "Vigour", "Perception", "Intellect", "Will", "Luck"];

            for (int i = 0; i < Stats.Length; i++)
            {
                //Console.WriteLine($"Enter Character {statNames[i]}: ");
                //stats[i] = Convert.ToInt32(Console.ReadLine());
                Stats[i] = Convert.ToInt32(Program.promptUser($"Enter Character {StatNames[i]}: "));
                Stats[i] = Math.Clamp(Stats[i], 15, 50);
            }
            //calculate them, using the primary attributes collected above
            //Awareness = Agility + Perception
            //Awareness = stats[(int)STATS.Agility] + stats[(int)STATS.Perception];
            Awareness = calculateSecondaryStat(Stats, STATS.Agility, STATS.Perception);
            //Toughness = Strength + Vigour;
            Toughness = calculateSecondaryStat(Stats, STATS.Strength, STATS.Vigour);
            //Resolve = Intellect + Will;
            Resolve = calculateSecondaryStat(Stats, STATS.Intellect, STATS.Will);
        }

        public static int calculateSecondaryStat(int[] stats, STATS stat1, STATS stat2)
        {
            int advancedStat = stats[(int)stat1] + stats[(int)stat2];
            return advancedStat;
        }
        public void displayCharacterSheet()
        {
            //Display nicely formatted output(extra \n or multiple Console.WriteLine).
            //Create ASCII dividers(dashed lines) to separate the CharacterName, Primary Attributes and Secondary Attributes.
            //formatted strings because im fancy like that
            Console.WriteLine("\n{0}", CharacterName);
            Console.WriteLine("---------------------------");
            Console.WriteLine("AGI: {0,2:D2} | STR: {1,2:D2}", Stats[(int)STATS.Agility], Stats[(int)STATS.Strength]);
            Console.WriteLine("VIG: {0,2:D2} | PER: {1,2:D2}", Stats[(int)STATS.Vigour], Stats[(int)STATS.Perception]);
            Console.WriteLine("INT: {0,2:D2} | WIL: {1,2:D2}", Stats[(int)STATS.Intellect], Stats[(int)STATS.Will]);
            Console.WriteLine("LUC: {0,2:D2}", Stats[(int)STATS.Luck]);
            Console.WriteLine("---------------------------");
            //these can hit 100, but since theres no second column to worry about, no min length required
            Console.WriteLine("AWARENESS: {0,3}", Awareness);
            Console.WriteLine("TOUGHNESS: {0,3}", Toughness);
            Console.WriteLine("  RESOLVE: {0,3}", Resolve);
            Console.WriteLine("---------------------------");
        }
    }
}
