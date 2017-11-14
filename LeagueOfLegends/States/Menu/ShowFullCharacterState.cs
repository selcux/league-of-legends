using System;
using LeagueOfLegends.Helpers;
using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.States.Menu {
    public class ShowFullCharacterState : MenuState {
        public ShowFullCharacterState(MenuManager manager)
            : base(manager) {
        }

        public override void Execute() {
            if (!_manager.GetData(this, out object data)) {
                return;
            }

            var character = data as BaseCharacter;

            Console.Out.WriteLine(string.Empty);
            Console.Out.WriteLine(OutputFormatter.CharacterToString(character));
        }

        protected override MenuState GetNextState(BaseCharacter character) {
            throw new System.NotImplementedException();
        }
    }
}