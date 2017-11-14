namespace LeagueOfLegends.Models.Characters {
    public abstract class BaseCharacter {
        public string Name { get; set; }
        public virtual int HealthPoint { get; set; }
        public virtual int AttachPoint { get; set; }

        protected BaseCharacter(string name) {
            Name = name;
        }
    }
}