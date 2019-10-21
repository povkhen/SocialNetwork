using Messager.Data.Interfaces;
using Messager.Data.Models.Conversations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Models.Messages
{
    public abstract class Message : IMessageActions
    {
        public User Sender { get; private set; }
        public readonly Conversation _conversation;
        public Message(User sender, Conversation conversation)
        {
            Sender = sender;
            _conversation = conversation;
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IMessageActions Edit()
        {
            throw new NotImplementedException();
        }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}
