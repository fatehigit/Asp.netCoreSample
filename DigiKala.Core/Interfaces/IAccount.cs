using DigiKala.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiKala.Core.Interfaces
{
    public interface IAccount
    {
        bool ExistsMobileNumber(string mobileNumber);

        //bool ExistsMailAddress(string mailAddress);

        void AddUser(User user);

        int GetMaxRole();

        int GetStoreRole();

        int GetUserId(string mobileNumber);

        bool ActivateUser(string code);

        User LoginUser(string mobileNumber, string password);

        bool ResetPassword(string code, string password);

        string GetUserActiveCode(string mobileNumber);

        //void AddStore(Store store);

        void UpdateUserRole(string mobileNumber);

    }
}
