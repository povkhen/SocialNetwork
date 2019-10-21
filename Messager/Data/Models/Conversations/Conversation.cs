using Messager.Data.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Models.Conversations
{
    public abstract class Conversation
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Image { get; private set; }
        public List<Message> Messages { get; private set; }
        public List<User> Members { get; protected set; }
        
    }
}
