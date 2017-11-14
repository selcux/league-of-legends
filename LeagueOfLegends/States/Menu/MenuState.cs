using System.Threading.Tasks;
using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.States.Menu {
    public abstract class MenuState : State {
        protected readonly MenuManager _manager;

        protected MenuState(MenuManager manager) {
            _manager = manager;
        }

        protected abstract MenuState GetNextState(BaseCharacter character);
    }
}