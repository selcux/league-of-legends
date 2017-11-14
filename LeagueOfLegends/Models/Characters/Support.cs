using LeagueOfLegends.Models.Characters.ItemSets;
using LeagueOfLegends.Models.Items.Attack;

namespace LeagueOfLegends.Models.Characters {
    public class Support : BaseCharacter, ISupportItemSet {
        private int _attachPoint;

        public BaseAttackItem AttackItem { get; set; }

        public override int AttachPoint {
            get => _attachPoint + (AttackItem?.Xp(this) ?? 0);
            set => _attachPoint = value;
        }

        public Support(string name)
            : base(name) {
        }
    }
}