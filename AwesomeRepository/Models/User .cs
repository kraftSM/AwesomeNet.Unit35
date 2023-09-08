﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AwesomeNet.Repository.Models
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
        
 
        public User()
        {
            //Image = "https://via.placeholder.com/500";
            Image = "/img/husky_100.png";
            Status = "Ура! Я в соцсети!";
            Info = "Информация обо мне.";
        }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
    }
}
