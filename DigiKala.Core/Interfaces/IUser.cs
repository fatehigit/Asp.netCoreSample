using System;
using System.Collections.Generic;
using System.Text;

using DigiKala.DataAccessLayer.Entities;

namespace DigiKala.Core.Interfaces
{
    public interface IUser
    {
        bool ExistsPermission(int permissionID, int roleID);
        int GetUserRole(string username);
        string GetUserRoleName(string username);

    }
}
