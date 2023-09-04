using AwesomeNet.Unit35.Models;
using System;
using System.Collections.Generic;

namespace AwesomeNet.Unit35.ViewModels.Account
{
    public class UserViewModel
    {
        public User user { get; set; }
        public List<User> Friends { get; set; }

        public UserViewModel(User user)
        {
            this.user = user;
        }
    }
}
