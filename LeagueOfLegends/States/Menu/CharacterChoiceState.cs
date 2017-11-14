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
            var characters = DataProvider.GetCharacters() as IList<BaseCharacter>;

            if (characters == null) {
                throw new ArgumentNullException("Karakter listesi bulunamadı.");
            }

            Console.Out.WriteLine(OutputFormatter.CharactersToString(characters));
            Console.Out.Write("Bir karakter seç: ");
            var choiceStr = Console.In.ReadLine();

            if (!int.TryParse(choiceStr, out var choice) || choice < 1) {
                Console.Out.WriteLine("Hatalı giriş yaptınız tekrar deneyin.");
            }

            var character = characters[choice - 1];
            var nextState = new ItemChoiceState(_manager);

            _manager.SetData(nextState, character);
            _manager.State = nextState;
        }
    }
}