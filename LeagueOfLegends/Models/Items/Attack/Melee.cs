using LeagueOfLegends.Helpers;
using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.Models.Items.Attack {
    public class Melee : BaseAttackItem {
        public override int Xp(BaseCharacter character) {
            switch (character) {
                case Warrior _:
                    return DataProvider.ItemData.Warrior.Melee;

                case Support _:
                    return DataProvider.ItemData.Support.Melee;
            }

            return 0;
        }
    }
}