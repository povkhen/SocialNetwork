using Messager.Data.Interfaces;
using Messager.Data.Models.Conversations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Mocks
{
    public class MockConversations : IConversationsGetter
    {
        private readonly IUsersGetter _users = new MockUsers();
        //private readonly IMessagesGetter _messages = new MockMessages();
        public IEnumerable<Conversation> AllCoversations => new List<Conversation>
        {
            new Dialogue(_users.AllUsers.ToList()[0], _users.AllUsers.ToList()[1])
        };

        public Conversation GetForId(int id)
        {
            throw new NotImplementedException();
        }

        public Conversation GetForName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Conversation> GetFromUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
