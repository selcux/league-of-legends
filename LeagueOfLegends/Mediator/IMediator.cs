namespace LeagueOfLegends.Mediator {
    public interface IMediator {
        void Subscribe(IMessageObject messageObject);

        void Send(string receiverKey,
            IMessageObject sender,
            MessageArgs args);
    }
}