using System.Threading.Tasks;

namespace LeagueOfLegends.States.Menu {
    public abstract class MenuState : State {
        protected MenuManager _manager;

        protected MenuState(MenuManager manager) {
            _manager = manager;
        }
    }
}