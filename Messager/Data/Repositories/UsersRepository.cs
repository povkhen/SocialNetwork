using Messager.Data.DB;
using Messager.Data.Interfaces;
using Messager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Repositories
{
    public class UsersRepository : IUsersGetter
    {
        private readonly AppDBContent _appDBContent;
        public UsersRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<User> AllUsers => _appDBContent.Users.Include(m => m.Conversations);

        public User GetForId(int id)
        {
            throw new NotImplementedException();
        }

        public User GetForNickname(string nickname)
        {
            throw new NotImplementedException();
        }

        public User GetForPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetFromConversation(int convId)
        {
            throw new NotImplementedException();
        }
    }
}
