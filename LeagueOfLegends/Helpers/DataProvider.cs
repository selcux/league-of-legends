using System.Collections.Generic;
using System.IO;
using LeagueOfLegends.Models.Characters;
using LeagueOfLegends.Models.Data;
using LeagueOfLegends.Models.Items;
using Newtonsoft.Json;

namespace LeagueOfLegends.Helpers {
    public class DataProvider {
        private const string CharacterFilePath = @"Data\characters.json";

        public static string Read(string filePath) => File.ReadAllText(filePath);

        public static IEnumerable<BaseCharacter> GetCharacters() {
            var characterData = JsonConvert.DeserializeObject<CharacterData>(Read(CharacterFilePath));

            var characters = new List<BaseCharacter>(characterData.Warriors);
            characters.AddRange(characterData.Mages);
            characters.AddRange(characterData.Supports);

            return characters;
        }
    }
}