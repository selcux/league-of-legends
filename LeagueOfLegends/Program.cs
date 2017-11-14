using System;
using LeagueOfLegends.States.Menu;

namespace LeagueOfLegends {
    class Program {
        private static void Main(string[] args) {
            var menu = new MenuManager();
            menu.State = new CharacterChoiceState(menu);

            Console.ReadKey();
        }
    }
}