using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Common.DTOs;
using Tasl.Repository.Entities;

namespace Task.Service.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();

        Task<UserDTO> UpdateAsync(UserDTO r);
    }
}
