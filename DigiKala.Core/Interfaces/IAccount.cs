using DigiKala.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiKala.Core.Interfaces
{
    public interface IAccount
    {
        bool ExistsMobileNumber(string mobileNumber);
        void AddUser(User user);

    }
}
