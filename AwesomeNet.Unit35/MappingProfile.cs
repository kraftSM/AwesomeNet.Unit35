﻿using AutoMapper;
using AwesomeNet.Unit35.Models;
using AwesomeNet.Unit35.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeNet.Unit35
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterViewModel, User>()
                //.ForMember(x => x.BirthDate, opt => opt.MapFrom(c => new DateTime((int)c.Year, (int)c.Month, (int)c.Date)))
                .ForMember(x => x.Email, opt => opt.MapFrom(c => c.EmailReg))
                .ForMember(x => x.UserName, opt => opt.MapFrom(c => c.Login));
            CreateMap<LoginViewModel, User>();
            //CreateMap<LoginViewModel, User>()
            //.ForMember(x => x.Email, opt => opt.MapFrom(c => c.Email));
        }
    }
}
