using LeagueOfLegends.Models.Characters.ItemSets;
using LeagueOfLegends.Models.Items.Attack;
using LeagueOfLegends.Models.Items.Health;

namespace LeagueOfLegends.Models.Characters {
    public class Warrior : BaseCharacter, IWarriorItemSet {
        private int _healthPoint, _attachPoint;

        public BaseAttackItem AttackItem { get; set; }
        public BaseHealthItem HealthItem { get; set; }

        public override int HealthPoint {
            get => _healthPoint + (HealthItem?.Hp(this) ?? 0);
            set => _healthPoint = value;
        }

        public override int AttachPoint {
            get => _attachPoint + (AttackItem?.Xp(this) ?? 0);
            set => _attachPoint = value;
        }

        public Warrior(string name)
            : base(name) {
        }
    }
}