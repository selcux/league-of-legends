using LeagueOfLegends.Models.Characters.ItemSets;
using LeagueOfLegends.Models.Items.Health;

namespace LeagueOfLegends.Models.Characters {
    public class Mage : BaseCharacter, IMageItemSet {
        public BaseHealthItem HealthItem { get; }

        public Mage(
            string name,
            int healthPoint,
            int attachPoint,
            BaseHealthItem healthItem)
            : base(name, healthPoint, attachPoint) {
            HealthItem = healthItem;
        }
    }
}