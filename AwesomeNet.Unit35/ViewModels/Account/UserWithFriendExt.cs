﻿using AwesomeNet.BLL.Models;

namespace AwesomeNet.ViewModels.Account
{
    public class UserWithFriendExt : User
    {
        public bool IsFriendWithCurrent { get; set; }
    }
}