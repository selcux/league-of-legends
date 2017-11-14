using System.Collections.Generic;
using LeagueOfLegends.Helpers.Generics;

namespace LeagueOfLegends.Mediator {
    public class Mediator : Singleton<Mediator>, IMediator {
        private readonly Dictionary<string, IMessageObject> _messageObjects = new Dictionary<string, IMessageObject>();

        public void Subscribe(IMessageObject messageObject) {
            if (!_messageObjects.ContainsKey(messageObject.ObjectKey)) {
                _messageObjects.Add(messageObject.ObjectKey, messageObject);
            }
        }

        public void Send(string receiverKey,
            IMessageObject sender,
            MessageArgs args) {
            var receiver = _messageObjects[receiverKey];

            receiver?.Receive(sender, args);
        }
    }
}