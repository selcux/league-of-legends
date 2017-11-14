using LeagueOfLegends.Helpers;
using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.Models.Items.Health {
    public class BlueMagic : BaseHealthItem {
        public override int Hp(BaseCharacter character) {
            switch (character) {
                case Warrior _:
                    return DataProvider.ItemData.Warrior.BlueMagic;

                case Mage _:
                    return DataProvider.ItemData.Mage.BlueMagic;
            }

            return 0;
        }
    }
}