using AwesomeNet.Front.ViewModels.Account;
using AwesomeNet.Repository.Models;

namespace AwesomeNet.BLL
{
    /// <summary>
    /// класс, который позволяет получить из вьюмодели модель пользователя
    /// </summary>
    public static class UserFromModel
    {
        public static User Convert(this User user, EditUserViewModel usereditvm)
        {
            user.Image = usereditvm.Image;
            user.LastName = usereditvm.LastName;
            user.MiddleName = usereditvm.MiddleName;
            user.FirstName = usereditvm.FirstName;
            user.Email = usereditvm.eMail;
            user.BirthDate = usereditvm.BirthDate;
            user.UserName = usereditvm.UserName;
            user.Status = usereditvm.Status;
            //user.About = usereditvm.About;

            return user;
        }
    }
}
