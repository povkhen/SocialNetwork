using Messager.Data.Models.Conversations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Models
{
    public class UserConversation
    {
        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
