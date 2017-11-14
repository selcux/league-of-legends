using System.Collections.Generic;

namespace LeagueOfLegends.States.Menu {
    public class MenuManager {
        private MenuState _state;

        private readonly Dictionary<MenuState, object> _dataDict = new Dictionary<MenuState, object>();

        public MenuState State {
            get => _state;
            set {
                _state = value;

                _state.Execute();
            }
        }

        public bool GetData<T>(MenuState key,
            out T data) {
            data = default(T);

            if (!_dataDict.ContainsKey(key)) {
                return false;
            }

            if (!(_dataDict[key] is T variable)) {
                return false;
            }

            data = variable;
            return true;
        }

        public void SetData(MenuState key,
            object data) {
            _dataDict.Add(key, data);
        }
    }
}