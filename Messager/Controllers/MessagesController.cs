using Messager.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Messager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessagesGetter _allMessages;
        private readonly IConversationsGetter _allConversations;
        public MessagesController(IMessagesGetter messagesGetter, IConversationsGetter conversationsGetter)
        {
            _allMessages = messagesGetter;
            _allConversations = conversationsGetter;
        }

        public ViewResult Dialog()
        {
            return View(_allMessages.AllMessges);
        }
        public ViewResult AllMessages()
        {
            MessagesAllMessagesViewModel obj = new MessagesAllMessagesViewModel();
            obj.messages = _allMessages.AllMessges;
            return View(obj);
        }
    }
}
