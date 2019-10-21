using Messager.Data.Models.Conversations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Interfaces
{
    public interface IConversationsGetter
    {
        IEnumerable<Conversation> AllCoversations { get; }
        IEnumerable<Conversation> GetFromUser(int id);
        Conversation GetForId(int id); 
        Conversation GetForName(string name);
    }
}
