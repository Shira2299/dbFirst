using AutoMapper;
using Task.Common.DTOs;
using Task.Service.Interfaces;
using Task.Service.Services;
using Tasl.Repository.Entities;

namespace Task.Service
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}