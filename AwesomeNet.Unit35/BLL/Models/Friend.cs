
using System;
using System.Collections.Generic;
using System.Linq;

namespace AwesomeNet.BLL.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public string UserFriendId { get; set; }

        public User UserFriend { get; set; }
    }
}
