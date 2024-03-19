using ArtWorkSharingAPI.Services;
using AWS_BusinessObjects.Common.Interfaces;
using AWS_Repository.Identity;
using AWS_BusinessObjects.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
using AWS_Repository.Interface;
using AWS_Repository.Repositories;
using AWS_Services.Interface;
using AWS_Services.Services;
using AWS_DAO;
using Newtonsoft.Json;
using AWS_BusinessObjects.Entities;

namespace Microsoft.Extensions.DependencyInjection;
public static class ConfigureServices
{
    public static IServiceCollection AddAPIServices(this IServiceCollection services)
    {
        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddScoped<ICurrentUserService, CurrentUserService>();

        services.AddHttpContextAccessor();

        services.AddHealthChecks()
            .AddDbContextCheck<ApplicationDbContext>();

        services.AddControllersWithViews();

        services.AddRazorPages();

        //----------DI------------------
        // Service
        services.AddScoped<IArtWorkService, ArtWorkService>();
        services.AddScoped<IPackageService, PackageService>();
        services.AddScoped<IPaymentMethodService,PaymentMethodService>();
        services.AddScoped<IPackageDetailsService, PackageDetailsService>();
        services.AddScoped<IInteractService, InteractService>();
        services.AddScoped<IRatingService, RatingService>();
        services.AddScoped<IOrderService,OrderService>();

        //services.AddScoped<IAdminAccountRepository, AdminAccountRepository>();
        // Repository
        services.AddScoped<IAccountRepository, AccountRepository>();

        services.AddScoped<IArtWorkRepository, ArtWorkRepository>();        
        services.AddScoped<IPackageRepository,PackageRepository>();
        services.AddScoped<IPaymentMethodRepository,PaymentMethodRepository>();
        services.AddScoped<IPackageDetailsRepository, PackageDetailsRepository>();
        services.AddScoped<IInteractRepository,InteractRepository>();
        services.AddScoped<IRatingRepository, RatingRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();

        // DAO
        services.AddScoped<ArtWorkDAO>();
        services.AddScoped<PackageDAO>();
        services.AddScoped<PaymentMethodDAO>();
        services.AddScoped<PackageDetailsDAO>();
        services.AddScoped<InteractDAO>();
        services.AddScoped<RatingDAO>();
        services.AddScoped<OrderDAO>();

        // Customise default API behaviour
        services.Configure<ApiBehaviorOptions>(options =>
            options.SuppressModelStateInvalidFilter = true);

        services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo { Title = "Art Work Sharing API", Version = "v1" });
            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter a valid token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
        });
        return services;
    }
}
