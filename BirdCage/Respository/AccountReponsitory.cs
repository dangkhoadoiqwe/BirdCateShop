using DataAccess;
using Model.Models;
using System;
using System.Collections.Generic;

namespace Respository
{
    public class AccountReponsitory : IAccountRepository
    {
        public Account Login(string username, string password) => AccountDao.Login(username , password);
        public List<Account> getall() => AccountDao.LoadAllAccounts();
 
    }
}
