using System;
using LeagueOfLegends.Models.Characters;
using LeagueOfLegends.Models.Characters.ItemSets;
using LeagueOfLegends.Models.Items.Health;

namespace LeagueOfLegends.States.Menu {
    public class HealthItemChoiceState : MenuState {
        public HealthItemChoiceState(MenuManager manager)
            : base(manager) {
        }

        public override void Execute() {
            Console.Out.WriteLine("1. Mavi Büyü");
            Console.Out.WriteLine("2. Yeşil Büyü");
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
                if (data is IMageItemSet itemSet) {
                    itemSet.HealthItem = GetHealthItem(choice);
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
            return new ShowFullCharacterState(_manager);
        }

        public static BaseHealthItem GetHealthItem(int choice) {
            switch (choice) {
                case 1:
                    return new BlueMagic();

                case 2:
                    return new GreenMagic();
            }

            return null;
        }
    }
}