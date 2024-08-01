using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Common.DTOs;

namespace Task.Service.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();
    }
}
