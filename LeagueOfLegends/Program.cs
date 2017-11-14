using System;
using LeagueOfLegends.Helpers;

namespace LeagueOfLegends {
    class Program {
        private static void Main(string[] args) {
            var characters = CharacterDataProvider.GetCharacters();

            foreach (var character in characters) {
                Console.Out.WriteLine(OutputFormatter.WriteLine(character));
            }

            Console.ReadKey();
        }
    }
}