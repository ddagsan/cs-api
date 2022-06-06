using Core.Data;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Products;
using Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Infrastructure
{
    public class DependencyRegistrar
    {
        public static ServiceProvider Register(IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<CsContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            services.AddScoped<IDbContext, CsContext>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddControllers();

            ServiceProvider = services.BuildServiceProvider();
            return ServiceProvider;
        }

        public static ServiceProvider ServiceProvider { get; private set; }
    }
}
