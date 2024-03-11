using AutoMapper;
using Medium.Application.UseCases.MediumUser.Commands;
using Medium.Domain.DTOs;
using Medium.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Absatractions.Mapper
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, CreateUserCommand>().ReverseMap();
        }
    }
}
