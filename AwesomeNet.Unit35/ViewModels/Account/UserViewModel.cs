﻿using AwesomeNet.Unit35.Models;
using System.Collections.Generic;

namespace AwesomeNet.Unit35.ViewModels.Account
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel(User user)
        {
            User = user; 
        }       

    }
}
