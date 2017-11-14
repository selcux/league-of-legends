using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.Models.Items.Health {
    public abstract class BaseHealthItem : BaseItem {
        public abstract int Hp(BaseCharacter character);
    }
}