using GitProfileShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitProfileShopAPI.Utils
{
    public class UserListHelper
    {

        private static UserListHelper instance;

        public List<User> UserList { get; private set; }

        public UserListHelper()
        {
            UserList = new List<User>();
        }

        public static UserListHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserListHelper();
                }
                return instance;
            }
        }


        public void AddItemToList(Models.User item)
        {
            UserList.Add(item);
        }

        public void RemoveItemFromList(Models.User item)
        {
            UserList.Remove(item);
        }

    }
}