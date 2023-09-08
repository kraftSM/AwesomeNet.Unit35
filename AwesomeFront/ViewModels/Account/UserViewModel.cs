using AwesomeNet.Repository.Models;
using System;
using System.Collections.Generic;

namespace AwesomeNet.Front.ViewModels.Account
{
    public class UserViewModel
    {
        public User User { get; set; }

        public List<User> Friends { get; set; }

        public UserViewModel(User user)
        {
            User = user;
        }

    }
}
