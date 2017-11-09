using LeagueOfLegends.Models.Characters.ItemSets;
using LeagueOfLegends.Models.Items.Attack;
using LeagueOfLegends.Models.Items.Health;

namespace LeagueOfLegends.Models.Characters {
    public class Warrior : BaseCharacter, IWarriorItemSet {
        public BaseAttackItem AttackItem { get; }
        public BaseHealthItem HealthItem { get; }

        public Warrior(string name,
            int healthPoint,
            int attachPoint,
            BaseAttackItem attackItem,
            BaseHealthItem healthItem)
            : base(name, healthPoint, attachPoint) {
            AttackItem = attackItem;
            HealthItem = healthItem;
        }
    }
}