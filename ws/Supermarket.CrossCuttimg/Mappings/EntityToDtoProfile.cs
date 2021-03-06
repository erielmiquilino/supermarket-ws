﻿using AutoMapper;
using Supermarket.Domain.Dtos.Users;
using Supermarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDtoCreate, User>()
                .ReverseMap();

            CreateMap<UserDtoCreateResult, User>()
                .ReverseMap();

            CreateMap<UserDtoUpdateResult, User>()
                .ReverseMap();
        }
    }
}
