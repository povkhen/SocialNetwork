using Messager.Data.Models;
using Messager.Data.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Data.Interfaces
{
    public interface IMessageActions
    {
        void Send();
        void Delete();
        IMessageActions Edit();
    }
}
