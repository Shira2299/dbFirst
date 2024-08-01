using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasl.Repository.Entities;
using Tasl.Repository.Interfaces;

namespace Tasl.Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly TasksContext _tasksContext;
        public UserRepository(TasksContext tasksContext)
        {
            _tasksContext = tasksContext;
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _tasksContext.Users.ToListAsync();
        }
    }
}
