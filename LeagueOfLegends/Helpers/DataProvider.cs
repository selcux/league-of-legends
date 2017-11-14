using System.Collections.Generic;
using System.IO;
using LeagueOfLegends.Models.Characters;
using LeagueOfLegends.Models.Data;
using Newtonsoft.Json;

namespace LeagueOfLegends.Helpers {
    public static class DataProvider {
        private const string CharacterFilePath = @"Data\characters.json";
        private const string ItemFilePath = @"Data\item_values.json";

        private static ItemData _itemData;

        public static string Read(string filePath) => File.ReadAllText(filePath);

        public static IEnumerable<BaseCharacter> GetCharacters() {
            var characterData = JsonConvert.DeserializeObject<CharacterData>(Read(CharacterFilePath));

            var characters = new List<BaseCharacter>(characterData.Warriors);
            characters.AddRange(characterData.Mages);
            characters.AddRange(characterData.Supports);

            return characters;
        }

        public static ItemData GetItems() =>
            JsonConvert.DeserializeObject<ItemData>(Read(ItemFilePath));

        public static ItemData ItemData => _itemData ?? (_itemData = GetItems());
    }
}