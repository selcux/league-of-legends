using LeagueOfLegends.Helpers;
using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.Models.Items.Health {
    public class GreenMagic : BaseHealthItem {
        public override int Hp(BaseCharacter character) {
            switch (character) {
                case Warrior _:
                    return DataProvider.ItemData.Warrior.GreenMagic;

                case Mage _:
                    return DataProvider.ItemData.Mage.GreenMagic;
            }

            return 0;
        }
    }
}