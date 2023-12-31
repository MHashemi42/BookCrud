﻿using BookCrud.Application.Common.Interfaces;
using BookCrud.Infrastructure.Authentication;
using BookCrud.Infrastructure.Authentication.OptionsSetup;
using BookCrud.Infrastructure.Data;
using BookCrud.Infrastructure.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookCrud.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("DefaultConnection");
        ArgumentException.ThrowIfNullOrEmpty(connectionString);

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services
           .AddIdentityCore<ApplicationUser>()
           .AddRoles<IdentityRole>()
           .AddEntityFrameworkStores<ApplicationDbContext>();

        services.Configure<IdentityOptions>(options =>
        {
            options.User.RequireUniqueEmail = true;
        });

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IJwtProvider, JwtProvider>();

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer();
        services.AddAuthorization();
        
        services.ConfigureOptions<JwtOptionsSetup>();
        services.ConfigureOptions<JwtBearerOptionsSetup>();

        return services;
    }
}
