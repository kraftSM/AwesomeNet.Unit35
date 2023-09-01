
using System;
using System.Collections.Generic;
using System.Linq;

namespace AwesomeNet.Unit35.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        
        public string userFriendId { get; set; }
        public User userFriend { get; set; }
    }
}
