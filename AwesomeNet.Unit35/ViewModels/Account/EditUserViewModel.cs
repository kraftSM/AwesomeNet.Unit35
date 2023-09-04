using AwesomeNet.Unit35.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AwesomeNet.Unit35.ViewModels.Account
{
    public class EditUserViewModel
    {
        public string UserId { get; set; }

        [Display(Name = "Имя", Prompt = "Введите имя")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия", Prompt = "Введите фамилию")]
        public string LastName { get; set; }

        [Display(Name = "Отчество", Prompt = "Введите отчество")]
        public string MiddleName { get; set; }

        [Display(Name = "Дата рождения")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Фото", Prompt = "Укажите ссылку на изображение")]
        public string Image { get; set; }

        [Display(Name = "Статус", Prompt = "Введите статус")]
        public string Status { get; set; }

        [Display(Name = "О себе", Prompt = "Введите данные о себе")]
        public string About { get; set; }

        [Display(Name = "Email", Prompt = "my_mail@example.com")]
        public string eMail { get; set; }

        public string UserName => eMail; //так делается соответствие. мы авторизуемся по почте. Соответственно при смене почты поменяется username пользователя.
    }
}
