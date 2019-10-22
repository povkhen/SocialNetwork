using Messager.Data.Models.Conversations;
using Messager.Data.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<UserConversation> Conversations { get; set; }
        public List<Message> Messages { get; set; }
        //public string FirstName { get; private set; }

        public User()
        {
            Conversations = new List<UserConversation>();
            Messages = new List<Message>();
        }
        public User(string firstName, string lastName, string nickName, string phone) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            Phone = phone;
        }

        
    }
}
