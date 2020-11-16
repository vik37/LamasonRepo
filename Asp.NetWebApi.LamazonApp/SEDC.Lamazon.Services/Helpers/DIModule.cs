using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SEDC.Lamazon.Domain.DomainModels;
using SEDC.LAMAZON.DataAccess;
using SEDC.LAMAZON.DataAccess.Interfaces;
using SEDC.LAMAZON.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Helpers
{
    public static class DIModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<LamazonDbContext>(options => options.UseSqlServer(connectionString));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Product>, ProductRepository>();

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddEntityFrameworkStores<LamazonDbContext>()
                .AddDefaultTokenProviders();
            return services;
        }
        
    }
}
