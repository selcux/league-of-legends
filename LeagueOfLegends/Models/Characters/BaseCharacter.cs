namespace LeagueOfLegends.Models.Characters {
    public abstract class BaseCharacter {
        public string Name { get; set; }
        public int HealthPoint { get; set; }
        public int AttachPoint { get; set; }

        protected BaseCharacter(string name,
            int healthPoint,
            int attachPoint) {
            Name = name;
            HealthPoint = healthPoint;
            AttachPoint = attachPoint;
        }
    }
}