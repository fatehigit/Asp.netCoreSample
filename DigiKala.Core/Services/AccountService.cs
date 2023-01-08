using DigiKala.Core.Interfaces;
using DigiKala.DataAccessLayer.Context;
using DigiKala.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiKala.Core.Services
{
    public class AccountService :IAccount
    {
        private DatabaseContext _context;

        public AccountService(DatabaseContext context)
        {
            _context = context;
        }
        public bool ExistsMobileNumber(string mobileNumber)
        {
            return _context.Users.Any(u => u.Mobile == mobileNumber);
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
