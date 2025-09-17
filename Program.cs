using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProgramming1
{
    internal class Program
    {
        static string[] partyNames = { "Member1", "Member2", "Member3", "Member4" };
        static int[] partyLevels = new int[4];



        static void Main(string[] args)
        {
            Console.WriteLine(partyNames[2]);

            partyLevels[0] = 1;
            partyLevels[1] = 1;
            partyLevels[2] = 1;
            partyLevels[3] = 1;

            LevelUpPartyMember("Member2");

            Console.WriteLine(partyLevels[0]);
            Console.WriteLine(partyLevels[1]);
            Console.WriteLine(partyLevels[2]);
            Console.WriteLine(partyLevels[3]);

            Console.WriteLine("Highest level: " + partyLevels.Max());

            int minValue = partyLevels.Min();
            Console.WriteLine("Lowest Level: " + minValue);

            Console.ReadKey();

        }

        static void LevelUpPartyMember(string memberName)
        {
            int indexOfPartyMember = Array.IndexOf(partyNames, memberName);

            partyLevels[indexOfPartyMember] += 1;
          
        }
    }
}
