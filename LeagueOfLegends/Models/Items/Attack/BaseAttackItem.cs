using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.Models.Items.Attack {
    public abstract class BaseAttackItem : BaseItem {
        public abstract int Xp(BaseCharacter character);
    }
}