using LeagueOfLegends.Helpers;
using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.Models.Items.Attack {
    public class Ranged : BaseAttackItem {
        public override int Xp(BaseCharacter character) {
            switch (character) {
                case Warrior _:
                    return DataProvider.ItemData.Warrior.Ranged;

                case Support _:
                    return DataProvider.ItemData.Support.Ranged;
            }

            return 0;
        }
    }
}