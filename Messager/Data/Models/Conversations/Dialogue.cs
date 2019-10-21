using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Models.Conversations
{
    public class Dialogue : Conversation
    {
        public Dialogue(User user1, User user2)
        {
            Members = new List<User> { user1, user2 };
        }
    }
}
