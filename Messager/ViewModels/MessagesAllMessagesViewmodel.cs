using Messager.Data.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.ViewModels
{
    public class MessagesAllMessagesViewModel
    {
        public IEnumerable<Message> messages { get; set; }
    }
}
