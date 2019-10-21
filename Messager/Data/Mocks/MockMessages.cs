using Messager.Data.Interfaces;
using Messager.Data.Models.Conversations;
using Messager.Data.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Mocks
{
    public class MockMessages : IMessagesGetter
    {
        private readonly IUsersGetter _users = new MockUsers();
        private readonly IConversationsGetter _conversations = new MockConversations();

        public IEnumerable<Message> AllMessges => new List<Message>
        {
            new TextMessage(_users.AllUsers.ToList()[0], _conversations.AllCoversations.ToList()[0], "Hello)"),
            new TextMessage(_users.AllUsers.ToList()[1], _conversations.AllCoversations.ToList()[0], "Hi!"),
            new TextMessage(_users.AllUsers.ToList()[0], _conversations.AllCoversations.ToList()[0], "How are you?"),
            new TextMessage(_users.AllUsers.ToList()[1], _conversations.AllCoversations.ToList()[0], "A'm OK")
        };
        

        IEnumerable<Message> IMessagesGetter.GetFromCoversations(int ConvId)
        {
            throw new NotImplementedException();
        }
        public Message GetForId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetForSubstring(string substring)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetFromUser(int id)
        {
            throw new NotImplementedException();
        }


    }
}
