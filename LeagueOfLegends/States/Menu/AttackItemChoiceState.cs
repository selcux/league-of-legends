using System;
using LeagueOfLegends.Models.Characters;
using LeagueOfLegends.Models.Characters.ItemSets;
using LeagueOfLegends.Models.Items.Attack;

namespace LeagueOfLegends.States.Menu {
    public class AttackItemChoiceState : MenuState {
        public AttackItemChoiceState(MenuManager manager)
            : base(manager) {
        }

        public override void Execute() {
            Console.Out.WriteLine("1. Kılıç");
            Console.Out.WriteLine("2. Silah");
            int choice;
            var loop = true;
            do {
                Console.Out.Write("Bir ekipman seç: ");
                var choiceStr = Console.In.ReadLine();

                if (!int.TryParse(choiceStr, out choice) || choice < 1 || choice > 2) {
                    Console.Out.WriteLine("Hatalı giriş yaptınız tekrar deneyin.");
                }
                else {
                    loop = false;
                }
            } while (loop);

            if (_manager.GetData(this, out object data)) {
                if (data is ISupportItemSet itemSet) {
                    itemSet.AttackItem = GetAttackItem(choice);
                }
                else {
                    throw new InvalidCastException("Karakter ve ekipman uyumsuz.");
                }
            }

            var character = data as BaseCharacter;
            var nextState = GetNextState(character);

            _manager.SetData(nextState, data);
            _manager.State = nextState;
        }

        protected override MenuState GetNextState(BaseCharacter character) {
            return character is Warrior
                ? (MenuState) new HealthItemChoiceState(_manager)
                : new ShowFullCharacterState(_manager);
        }

        private static BaseAttackItem GetAttackItem(int choice) {
            switch (choice) {
                case 1:
                    return new Melee();

                case 2:
                    return new Ranged();
            }

            return null;
        }
    }
}