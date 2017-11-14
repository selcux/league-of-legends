using System.Collections.Generic;
using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.Models.Data {
    public class CharacterData {
        public IEnumerable<Warrior> Warriors { get; set; }
        public IEnumerable<Mage> Mages { get; set; }
        public IEnumerable<Support> Supports { get; set; }
    }
}