﻿using Messager.Data.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Models.Conversations
{
    public abstract class Conversation
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Image { get;  set; }
        public List<Message> Messages { get; set; }
        public List<UserConversation> Members { get;  set; }
        public Conversation()
        {
            Messages = new List<Message>();
            Members = new List<UserConversation>();
        }
    }
}
