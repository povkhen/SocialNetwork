using Messager.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessagesGetter _allMessages;
        public MessagesController(IMessagesGetter messagesGetter)
        {
            _allMessages = messagesGetter;
        }

        public ViewResult AllMessages()
        {
            return View(_allMessages.AllMessges);
        }
    }
}
