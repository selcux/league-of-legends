using System.Collections.Generic;
using System.IO;
using LeagueOfLegends.Models.Characters;
using LeagueOfLegends.Models.Data;
using Newtonsoft.Json;

namespace LeagueOfLegends.Helpers {
    public class CharacterDataProvider {
        private const string CharacterFilePath = @"Data\characters.json";

        public static string Read() => File.ReadAllText(CharacterFilePath);

        public static IEnumerable<BaseCharacter> GetCharacters() {
            var characterData = JsonConvert.DeserializeObject<CharacterData>(Read());

            var characters = new List<BaseCharacter>(characterData.Warriors);
            characters.AddRange(characterData.Mages);
            characters.AddRange(characterData.Supports);

            return characters;
        }
    }
}