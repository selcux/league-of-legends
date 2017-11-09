using LeagueOfLegends.Models.Characters.ItemSets;
using LeagueOfLegends.Models.Items.Attack;

namespace LeagueOfLegends.Models.Characters {
    public class Support : BaseCharacter, ISupportItemSet {
        public BaseAttackItem AttackItem { get; }

        public Support(string name,
            int healthPoint,
            int attachPoint,
            BaseAttackItem attackItem)
            : base(name, healthPoint, attachPoint) {
            AttackItem = attackItem;
        }
    }
}