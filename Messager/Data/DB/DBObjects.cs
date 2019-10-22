using Messager.Data.Models;
using Messager.Data.Models.Conversations;
using Messager.Data.Models.Messages;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.DB
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Users.Any())
                content.Users.AddRange(Users.Select(u => u.Value));
            if (!content.Conversations.Any())
                content.Conversations.AddRange(Conversations.Select(c => c.Value));
            if (!content.Messages.Any())
                content.Messages.AddRange(Messages);

            //content.SaveChanges();


            User dima = Users["ponzel.dima35"];
            User misha = Users["povhmisha"];
            User slava = Users["yaroslavponzel"];

            Conversation m_d = Conversations["povhmisha - ponzel.dima35"];
            Conversation d_y = Conversations["ponzel.dima35 - yaroslavponzel"];

            dima.Conversations.Add(new UserConversation { UserId = dima.Id, ConversationId = m_d.Id });
            dima.Conversations.Add(new UserConversation { UserId = dima.Id, ConversationId = d_y.Id });
            misha.Conversations.Add(new UserConversation { UserId = misha.Id, ConversationId = m_d.Id });
            slava.Conversations.Add(new UserConversation { UserId = slava.Id, ConversationId = d_y.Id });
            content.SaveChanges();
        }

        public static Dictionary<string, Conversation> conversations;
        public static Dictionary<string, Conversation> Conversations
        {
            get
            {
                if (conversations is null)
                {
                    var list = new Conversation[]
                    {
                        new Dialogue(){ NickName = "povhmisha - ponzel.dima35" },
                        new Dialogue(){ NickName = "ponzel.dima35 - yaroslavponzel" }
                    };

                    conversations = new Dictionary<string, Conversation>();
                    foreach (Conversation conversation in list)
                        conversations.Add(conversation.NickName, conversation);
                }
                return conversations;
            }
        }

        public static List<Message> messages;
        public static List<Message> Messages
        {
            get
            {
                if (messages is null)
                {
                    var list = new Message[]
                    {
                        new TextMessage(Users["ponzel.dima35"], Conversations["povhmisha - ponzel.dima35"], "Hello)"),
                        new TextMessage(Users["povhmisha"], Conversations["povhmisha - ponzel.dima35"], "Hi!"),
                        new TextMessage(Users["ponzel.dima35"], Conversations["povhmisha - ponzel.dima35"], "How are you?"),
                        new TextMessage(Users["povhmisha"], Conversations["povhmisha - ponzel.dima35"], "I`m OK. And you?!"),
                        new TextMessage(Users["ponzel.dima35"], Conversations["povhmisha - ponzel.dima35"], "I am too"),
                        new TextMessage(Users["povhmisha"], Conversations["povhmisha - ponzel.dima35"], "I am Misha!"),
                        new TextMessage(Users["povhmisha"], Conversations["povhmisha - ponzel.dima35"], "I am Mishaaaa!"),
                        new TextMessage(Users["povhmisha"], Conversations["povhmisha - ponzel.dima35"], "I am Mishaaaaaaaa!"),
                        new TextMessage(Users["povhmisha"], Conversations["povhmisha - ponzel.dima35"], "I am Mishaaaaaaaaaaaaa!"),
                        new TextMessage(Users["yaroslavponzel"], Conversations["ponzel.dima35 - yaroslavponzel"], "Zdorovichko!"),
                        new TextMessage(Users["yaroslavponzel"], Conversations["ponzel.dima35 - yaroslavponzel"], "Zdorovichko!")
                    };

                    messages = new List<Message>();
                    foreach (Message message in list)
                        messages.Add(message);
                }
                return messages;
            }
        }

        public static Dictionary<string, User> users;
        public static Dictionary<string, User> Users
        {
            get
            {
                if (users is null)
                {
                    var list = new User[]
                    {
                        new User("Dima", "Ponzel", "ponzel.dima35", "+380507854882") { Image = "/image/Dima.jpg" },
                        new User("Misha", "Povh", "povhmisha", "+380507854112") { Image = "/image/Misha.jpg" },
                        new User("Slava", "Ponzel", "yaroslavponzel", "+380992276091") { Image = "/image/Slava.jpg" }
                    };

                    users = new Dictionary<string, User>();
                    foreach (User user in list)
                        users.Add(user.NickName, user);
                }
                return users;
            }
        }
    }
}
