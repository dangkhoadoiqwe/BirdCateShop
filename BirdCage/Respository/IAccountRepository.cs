using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository
{
    public interface IAccountRepository
    {
        Account Login(string username, string password);
        List<Account> getall();
       
    }
}
