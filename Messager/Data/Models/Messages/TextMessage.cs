using Messager.Data.Interfaces;
using Messager.Data.Models.Conversations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Models.Messages
{
    public class TextMessage : Message
    {
        public string Text { get; private set; }
        public TextMessage(User sender, Conversation conversation, string text) : base(sender, conversation)
        {
            Text = text;
        }

    }
}
