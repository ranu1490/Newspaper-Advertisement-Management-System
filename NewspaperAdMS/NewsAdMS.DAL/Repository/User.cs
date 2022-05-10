using NewsAdMS.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAdMS.DAL.Repository
{
    internal class User : IUser
    {
        public string DeleteUser(int user_Id)
        {
            return "Deleted";
        }

        public List<UserDetails> GetAllUsers()
        {
            return new List<UserDetails>();
        }

        public UserDetails GetUser(int user_Id)
        {
            UserDetails userDetails = new UserDetails();
            return userDetails;
        }

        public string SaveUserDetails(UserDetails userDetails)
        {
            return "Saved";
        }

        public string UpdateUserDetails(UserDetails userDetails)
        {
            return "Updated";
        }
    }
}
