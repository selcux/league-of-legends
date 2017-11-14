namespace LeagueOfLegends.Models.Data {
    public class ItemData {
        public class WarriorClass : IClassAttackItems, IClassHealthItems {
            public int Melee { get; set; }
            public int Ranged { get; set; }
            public int BlueMagic { get; set; }
            public int GreenMagic { get; set; }
        }

        public class MageClass : IClassHealthItems {
            public int BlueMagic { get; set; }
            public int GreenMagic { get; set; }
        }

        public class SupportClass : IClassAttackItems {
            public int Melee { get; set; }
            public int Ranged { get; set; }
        }

        public WarriorClass Warrior { get; set; }
        public MageClass Mage { get; set; }
        public SupportClass Support { get; set; }
    }
}