using System;
using System.Collections.Generic;
using LeagueOfLegends.Helpers;
using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.States.Menu {
    public class CharacterChoiceState : MenuState {
        public CharacterChoiceState(MenuManager manager)
            : base(manager) {
        }

        public override void Execute() {
            if (!(DataProvider.GetCharacters() is IList<BaseCharacter> characters)) {
                throw new ArgumentNullException("Karakter listesi bulunamadı.");
            }

            Console.Out.WriteLine(OutputFormatter.CharactersToString(characters));
            int choice;
            var loop = true;
            do {
                Console.Out.Write("Bir karakter seç: ");
                var choiceStr = Console.In.ReadLine();

                if (!int.TryParse(choiceStr, out choice) || choice < 1 || choice > characters.Count) {
                    Console.Out.WriteLine("Hatalı giriş yaptınız tekrar deneyin.");
                }
                else {
                    loop = false;
                }
            } while (loop);

            var character = characters[choice - 1];
            var nextState = GetNextState(character);

            _manager.SetData(nextState, character);
            _manager.State = nextState;
        }

        protected override MenuState GetNextState(BaseCharacter character) {
            if (character is Mage) {
                return new HealthItemChoiceState(_manager);
            }

            return new AttackItemChoiceState(_manager);
        }
    }
}