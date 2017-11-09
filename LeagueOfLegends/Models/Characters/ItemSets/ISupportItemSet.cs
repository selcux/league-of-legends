using LeagueOfLegends.Models.Items.Attack;

namespace LeagueOfLegends.Models.Characters.ItemSets {
    public interface ISupportItemSet {
        BaseAttackItem AttackItem { get; }
    }
}