using Messager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Interfaces
{
    public interface IUsersGetter
    {
        IEnumerable<User> AllUsers { get; }
        IEnumerable<User> GetFromConversation(int convId);
        User GetForId(int id);
        User GetForNickname(string nickname);
        User GetForPhone(string phone);
    }
}
