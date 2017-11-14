using LeagueOfLegends.Models.Items.Health;

namespace LeagueOfLegends.Models.Characters.ItemSets {
    public interface IMageItemSet {
        BaseHealthItem HealthItem { get; set; }
    }
}