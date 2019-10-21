using Messager.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersGetter _allUsers;

        public UsersController(IUsersGetter usersGetter)
        {
            _allUsers = usersGetter;
        }

        public ViewResult List()
        {
            return View(_allUsers.AllUsers);
        }
    }
}
