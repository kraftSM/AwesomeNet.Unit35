using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AwesomeNet.Unit35.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public string Info { get; set; }
        public string GetFullName()
        {
            return " UserFullName: " + FirstName + " " + MiddleName + " " + LastName;
        }
        public User()
        {
            Image = "img/husky_400.png"; //Husky :)
            Status = "Ура! Я в соцсети!";
            Info = "Информация обо мне.";
        }
    }
}
