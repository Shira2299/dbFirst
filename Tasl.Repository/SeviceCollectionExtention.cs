using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tasl.Repository.Entities;
using Tasl.Repository.Interfaces;
using Tasl.Repository.Repository;

namespace Tasl.Repository
{
    public static class SeviceCollectionExtention
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<TasksContext>(opt => opt.UseSqlServer("Data Source=DESKTOP-24EQMFH;Initial Catalog=Tasks;TrustServerCertificate=true;Integrated Security=true;"));
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}