using Messager.Data.DB;
using Messager.Data.Interfaces;
using Messager.Data.Models.Conversations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Repositories
{
    public class ConversationsRepository : IConversationsGetter
    {
        private readonly AppDBContent _appDBContent;
        public ConversationsRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        public IEnumerable<Conversation> AllConversations => _appDBContent.Conversations.Include(c => c.Members).Include(c => c.Messages);

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
