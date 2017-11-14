namespace LeagueOfLegends.Mediator {
    public interface IMessageObject {
        string ObjectKey { get; }

        void Receive(IMessageObject sender,
            MessageArgs args);
    }
}