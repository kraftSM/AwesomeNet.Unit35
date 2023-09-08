using AwesomeNet.Repository.Models;

namespace AwesomeNet.Front.ViewModels.Account
{
    public class UserWithFriendExt : User
    {
        public bool IsFriendWithCurrent { get; set; }
    }
}