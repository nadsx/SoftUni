namespace Mediator
{
    using System.Collections.Generic;

    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    public class ChatRoom : AbstractChatRoom
    {
        private readonly Dictionary<string, Participant> participants =
            new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!this.participants.ContainsValue(participant))
            {
                this.participants[participant.Name] = participant;
            }

            participant.ChatRoom = this;
        }

        public override void Send(string from, string to, string message)
        {
            var participant = this.participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }

        public override void SendToAll(string @from, string message)
        {
            foreach (var participant in this.participants)
            {
                if (participant.Key != @from)
                {
                    participant.Value.Receive(from, message);
                }
            }
        }
    }
}
