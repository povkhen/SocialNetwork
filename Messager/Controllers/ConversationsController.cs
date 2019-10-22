using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Messager.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Messager.Controllers
{
    public class ConversationsController : Controller
    {
        private readonly IMessagesGetter _allMessages;
        private readonly IConversationsGetter _allConversations;
        public ConversationsController(IMessagesGetter messagesGetter, IConversationsGetter conversationsGetter)
        {
            _allMessages = messagesGetter;
            _allConversations = conversationsGetter;
        }

        public ViewResult Dialogue()
        {
            return View(_allConversations.AllConversations.ToList()[0]);
        }

    }
}