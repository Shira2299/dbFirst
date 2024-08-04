using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Common.DTOs;
using Task.Service.Interfaces;
using Tasl.Repository.Entities;
using Tasl.Repository.Interfaces;

namespace Task.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> UpdateAsync(UserDTO u)
        {
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(_mapper.Map<User>(u)));
            //הגישה הזו מאפשרת לך לשמור על הפרדה ברורה בין שכבות המערכת שלך ולהשתמש 
            //ב-DTOs 
            //להעברת נתונים בין שכבות מבלי לחשוף את הישויות הפנימיות שלך ישירות.
        }

    }
}
