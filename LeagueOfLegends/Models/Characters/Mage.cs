using LeagueOfLegends.Models.Characters.ItemSets;
using LeagueOfLegends.Models.Items.Health;

namespace LeagueOfLegends.Models.Characters {
    public class Mage : BaseCharacter, IMageItemSet {
        private int _healthPoint;

        public BaseHealthItem HealthItem { get; set; }

        public override int HealthPoint {
            get => _healthPoint + (HealthItem?.Hp(this) ?? 0);
            set => _healthPoint = value;
        }

        public Mage(string name)
            : base(name) {
        }
    }
}