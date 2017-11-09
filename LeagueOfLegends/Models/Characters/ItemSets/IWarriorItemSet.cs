using LeagueOfLegends.Models.Items.Attack;
using LeagueOfLegends.Models.Items.Health;

namespace LeagueOfLegends.Models.Characters.ItemSets {
    public interface IWarriorItemSet {
        BaseAttackItem AttackItem { get; }
        BaseHealthItem HealthItem { get; }
    }
}