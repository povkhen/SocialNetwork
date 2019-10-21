using Messager.Data.Models.Conversations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string NickName { get; private set; }
        public string Image { get; set; }
        public string Phone { get; private set; }
        public string Email { get; set; }
        public List<Conversation> Conversations { get; private set; }
        //public string FirstName { get; private set; }

        public User(string firstName, string lastName, string nickName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            Phone = phone;
        }

        
    }
}
