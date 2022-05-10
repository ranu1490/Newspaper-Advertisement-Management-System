using System;
using System.Collections.Generic;
using System.Text;
using NewsAdMS.Entity;

namespace NewsAdMS.DAL.Repository
{
    internal interface IUser
    {
        string SaveUserDetails(UserDetails userDetails);
        string UpdateUserDetails(UserDetails userDetails);
        string DeleteUser(int user_Id);
        UserDetails GetUser(int user_Id);
        List<UserDetails> GetAllUsers();
    }
}
