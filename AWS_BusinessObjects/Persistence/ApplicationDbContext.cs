﻿using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using AWS_BusinessObjects.Enums;
using AWS_BusinessObjects.Identity;
using AWS_BusinessObjects.Persistence.Interceptors;
using Azure;
using Duende.IdentityServer.EntityFramework.Options;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Persistence
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContext
    {
        private readonly IMediator _mediator;
        private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            IMediator mediator,
            AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor)
            : base(options, operationalStoreOptions)
        {
            _mediator = mediator;
            _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
        }
        public DbSet<ArtWork> ArtWorks => Set<ArtWork>();
        public DbSet<Interact> Interacts => Set<Interact>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Rating> Ratings => Set<Rating>();
        public DbSet<Report> Reports => Set<Report>();
        public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();
        public DbSet<WishList> WishLists => Set<WishList>();

        // seed data function

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<Category>()
               .HasData(
               new Category
               {
                   Id = Guid.Parse("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                   CategoryName = "Category 1",
                   Description = "Description Category 1"
               },
               new Category
               {
                   Id = Guid.Parse("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                   CategoryName = "Category 2",
                   Description = "Description Category 2"
               },
               new Category
               {
                   Id = Guid.Parse("53b50d7f-44eb-4dda-84b1-9d3c938eba22"),
                   CategoryName = "Category 3",
                   Description = "Description Category 3"
               },
               new Category
               {
                   Id = Guid.Parse("58c96dfc-1c31-429b-9c6c-378db1c68b2a"),
                   CategoryName = "Category 4",
                   Description = "Description Category 4"
               },
               new Category
               {
                   Id = Guid.Parse("5d935698-bc0f-4692-88a3-43234943be40"),
                   CategoryName = "Category 5",
                   Description = "Description Category 5"
               },
               new Category
               {
                   Id = Guid.Parse("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"),
                   CategoryName = "Category 6",
                   Description = "Description Category 6"
               }

               );


            // ApplicationUser Seed Data, 3 users
            builder.Entity<ApplicationUser>()
                .HasData(
                new ApplicationUser
                {
                    Id = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                    UserName = "TranHieu1",
                    NormalizedUserName = "TRANHIEU1",
                    Email = "hieu123@gmail.com",             
                },
                new ApplicationUser
                {
                    Id = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    UserName = "TranHieu2",
                    NormalizedUserName = "TRANHIEU2",
                    Email = "hieuaccount2@gmail.com"
                },
                new ApplicationUser
                {
                    Id = "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                    UserName = "TranHieu3",
                    NormalizedUserName = "TRANHIEU3",
                    Email = "hieuaccount3@gmail.com"
                },
                new ApplicationUser
                {
                    Id = "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                    UserName = "TranHieu4",
                    NormalizedUserName = "TRANHIEU4",
                    Email = "hieuaccount4@gmail.com"
                },
                new ApplicationUser
                {
                    Id = "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                    UserName = "TranHieu5",
                    NormalizedUserName = "TRANHIEU5",
                    Email = "hieuaccount5@gmail.com"
                }
                );

            // Artist Seed Data, 3 artists
            builder.Entity<ArtistAccount>()
                .HasData(
                new ArtistAccount
                {
                    Id = Guid.NewGuid(),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                    Created = DateTime.Now,
                    IsDeleted = false
                },
                new ArtistAccount
                {
                    Id = Guid.NewGuid(),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    Created = DateTime.Now,
                    IsDeleted = false
                },
                new ArtistAccount
                {
                    Id = Guid.NewGuid(),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                    Created = DateTime.Now,
                    IsDeleted = false
                }
                );


            // Audience Seed Data, 3 audiences
            builder.Entity<AudienceAccount>()
                .HasData(
                new AudienceAccount
                {
                    Id = Guid.NewGuid(),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                    Created = DateTime.Now,
                    IsDeleted = false
                },
                new AudienceAccount
                {
                    Id = Guid.NewGuid(),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                    Created = DateTime.Now,
                    IsDeleted = false
                }
                );

            // ArtWork Seed Data
            builder.Entity<ArtWork>()
                .HasData(
                new ArtWork
                {
                    Id = Guid.Parse("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                    UserOwnerId = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    Name = "ArtWork 1",
                    Description = "Description 1",
                    Price = 100,
                    ImageUrl = "https://img.cdn-pictorem.com/uploads/collection/D/DN4DFF8JRC/900_Nature-Art_10.jpg",
                    ArtWorkStatus = ArtWorkStatus.Active,
                    Created = DateTime.Now,
                    IsDeleted = false,
                    IsPreOrder = false,
                    CategoryId = Guid.Parse("b3cb8ee0-c965-4970-8ef0-baad50ebf987")
                },
                new ArtWork
                {
                    Id = Guid.Parse("26709dca-1906-4c50-a00e-1c63582ab644"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                    UserOwnerId = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    Name = "ArtWork 2",
                    Description = "Description 2",
                    Price = 200,
                    ImageUrl = "https://i.ebayimg.com/images/g/pAUAAOSw5yJjhMYl/s-l1200.webp",
                    ArtWorkStatus = ArtWorkStatus.Active,
                    Created = DateTime.Now,
                    IsDeleted = false,
                    IsPreOrder = true,
                    CategoryId = Guid.Parse("b1799e22-2212-43d2-a09a-6a0371f2d89c")
                },
                new ArtWork
                {
                    Id = Guid.Parse("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    UserOwnerId = "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                    Name = "ArtWork 3",
                    Description = "Description 3",
                    Price = 300,
                    ImageUrl = "https://media.takealot.com/covers_images/0e56acf396604d34ac7c414b287c7cd7/s-pdpxl.file",
                    ArtWorkStatus = ArtWorkStatus.Active,
                    Created = DateTime.Now,
                    IsDeleted = false,
                    IsPreOrder= true,
                    CategoryId = Guid.Parse("b3cb8ee0-c965-4970-8ef0-baad50ebf987")
                },
                new ArtWork
                {
                    Id = Guid.Parse("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    UserOwnerId = "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                    Name = "ArtWork 4",
                    Description = "Description 4",
                    Price = 400,
                    ImageUrl = "https://studio.pinotspalette.com/naperville/images/nap-uniquevangogh.jpg",
                    ArtWorkStatus = ArtWorkStatus.Active,
                    Created = DateTime.Now,
                    IsDeleted = false,
                    CategoryId = Guid.Parse("b1799e22-2212-43d2-a09a-6a0371f2d89c")
                },
                new ArtWork
                {
                    Id = Guid.Parse("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                    UserOwnerId = "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                    Name = "ArtWork 5",
                    Description = "Description 5",
                    Price = 500,
                    ImageUrl = "https://www.singulart.com/images/artworks/v2/cropped/2479/main/carousel/1844446_b5d87c0efe493d715a1d57f480131a2f.jpeg",
                    ArtWorkStatus = ArtWorkStatus.Active,
                    Created = DateTime.Now,
                    IsDeleted = false,
                    CategoryId = Guid.Parse("b3cb8ee0-c965-4970-8ef0-baad50ebf987")
                },
                new ArtWork
                {
                    Id = Guid.Parse("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                    UserOwnerId = "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                    Name = "ArtWork 6",
                    Description = "Description 6",
                    Price = 600,
                    ImageUrl = "https://images.saatchiart.com/saatchi/1093024/art/4707641/3777473-FIDYEXAV-7.jpg",
                    ArtWorkStatus = ArtWorkStatus.Active,
                    Created = DateTime.Now,
                    IsDeleted = false,
                    CategoryId = Guid.Parse("b3cb8ee0-c965-4970-8ef0-baad50ebf987")
                },
                new ArtWork
                {
                    Id = Guid.Parse("bd37c967-1817-495b-89eb-665c81b02d5e"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                    UserOwnerId = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    Name = "ArtWork 7",
                    Description = "Description 7",
                    Price = 700,
                    ImageUrl = "https://images.saatchiart.com/saatchi/770124/art/8867466/7930834-HSC00923-7.jpg",
                    ArtWorkStatus = ArtWorkStatus.Active,
                    Created = DateTime.Now,
                    IsDeleted = false,
                    CategoryId = Guid.Parse("b1799e22-2212-43d2-a09a-6a0371f2d89c")
                },
                new ArtWork
                {
                    Id = Guid.Parse("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                    UserOwnerId = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    Name = "ArtWork 8",
                    Description = "Description 8",
                    Price = 800,
                    ImageUrl = "https://scontent.fsgn5-3.fna.fbcdn.net/v/t1.6435-9/191815536_1305384429858113_8269960277638413432_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=FYh3OT-x0AIAX-Z3VNM&_nc_ht=scontent.fsgn5-3.fna&oh=00_AfCifetKtGNeQBaVh8Yrx3lnW3U1CxznHdMAZMB1a1w5XA&oe=6623B508",
                    ArtWorkStatus = ArtWorkStatus.Active,
                    Created = DateTime.Now,
                    IsDeleted = false,
                    CategoryId = Guid.Parse("b1799e22-2212-43d2-a09a-6a0371f2d89c")
                },
                new ArtWork
                {
                    Id = Guid.Parse("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    UserOwnerId = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                    Name = "ArtWork 9",
                    Description = "Description 9",
                    Price = 900,
                    ImageUrl = "https://scontent.fsgn5-11.fna.fbcdn.net/v/t1.6435-9/107542684_1068121206917771_2494785157216852040_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=o9rZ89Am3UEAX-VFzIF&_nc_ht=scontent.fsgn5-11.fna&oh=00_AfCNUsxrhFPBP5F0Yu-A-dnY-gT2TF8zwifP0MFBwfUTgQ&oe=66239792",
                    ArtWorkStatus = ArtWorkStatus.Active,
                    Created = DateTime.Now,
                    IsDeleted = false,
                    IsPreOrder = true,
                    CategoryId = Guid.Parse("b3cb8ee0-c965-4970-8ef0-baad50ebf987")
                },
                new ArtWork
                {
                    Id = Guid.Parse("d9d6b461-8efd-4395-8662-a58caa152200"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    UserOwnerId = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                    Name = "ArtWork 10",
                    Description = "Description 10",
                    Price = 1000,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/Vincent_Willem_van_Gogh_127.jpg/270px-Vincent_Willem_van_Gogh_127.jpg",
                    ArtWorkStatus = ArtWorkStatus.Active,
                    Created = DateTime.Now,
                    IsDeleted = false,
                    IsPreOrder = true,
                    CategoryId = Guid.Parse("b1799e22-2212-43d2-a09a-6a0371f2d89c")
                }
                );

            // Interact Seed Data
            builder.Entity<Interact>()
                .HasData(
                new Interact
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    ArtWorkID = Guid.Parse("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                    IsDeleted = false,
                    Comment = "Comment 1",
                    Date = DateTime.Now,
                    IsLike = true
                },
                new Interact
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    ArtWorkID = Guid.Parse("26709dca-1906-4c50-a00e-1c63582ab644"),
                    IsDeleted = false,
                    Comment = "Comment 2",
                    Date = DateTime.Now,
                    IsLike = true
                },
                new Interact
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    ArtWorkID = Guid.Parse("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                    IsDeleted = false,
                    Comment = "Comment 3",
                    Date = DateTime.Now,
                    IsLike = true
                },
                new Interact
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    ArtWorkID = Guid.Parse("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                    IsDeleted = false,
                    Comment = "Comment 4",
                    Date = DateTime.Now,
                    IsLike = true
                },
                new Interact
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    ArtWorkID = Guid.Parse("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                    IsDeleted = false,
                    Comment = "Comment 5",
                    Date = DateTime.Now,
                    IsLike = true
                },
                new Interact
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    ArtWorkID = Guid.Parse("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                    IsDeleted = false,
                    Comment = "Comment 6",
                    Date = DateTime.Now,
                    IsLike = true
                },
                new Interact
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    ArtWorkID = Guid.Parse("bd37c967-1817-495b-89eb-665c81b02d5e"),
                    IsDeleted = false,
                    Comment = "Comment 7",
                    Date = DateTime.Now,
                    IsLike = true
                },
                new Interact
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    ArtWorkID = Guid.Parse("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                    IsDeleted = false,
                    Comment = "Comment 8",
                    Date = DateTime.Now,
                    IsLike = true
                },
                new Interact
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    ArtWorkID = Guid.Parse("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                    IsDeleted = false,
                    Comment = "Comment 9",
                    Date = DateTime.Now,
                    IsLike = true
                },
                new Interact
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    ArtWorkID = Guid.Parse("d9d6b461-8efd-4395-8662-a58caa152200"),
                    IsDeleted = false,
                    Comment = "Comment 10",
                    Date = DateTime.Now,
                    IsLike = true
                }
                );

            // Order Seed Data
            builder.Entity<Order>()
                .HasData(
                new Order
                {
                    Id = Guid.Parse("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                    ArtWorkID = Guid.Parse("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                    Status = OrderStatus.Pending,
                    Created = DateTime.Now,
                    IsDeleted = false
                },
                new Order
                {
                    Id = Guid.Parse("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                    ArtWorkID = Guid.Parse("26709dca-1906-4c50-a00e-1c63582ab644"),
                    Status = OrderStatus.Pending,
                    Created = DateTime.Now,
                    IsDeleted = false
                },
                new Order
                {
                    Id = Guid.Parse("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                    UserAccountId = "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                    ArtWorkID = Guid.Parse("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                    Status = OrderStatus.Pending,
                    Created = DateTime.Now,
                    IsDeleted = false
                }
                );

            // Rating Seed Data, 3 Ratings
            builder.Entity<Rating>()
                .HasData(
                new Rating
                {
                    Id = Guid.NewGuid(),
                    OrderID = Guid.Parse("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                    Description = "Description 1",
                    Point = 5,
                    Created = DateTime.Now,
                    IsDeleted = false
                },
                new Rating
                {
                    Id = Guid.NewGuid(),
                    OrderID = Guid.Parse("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                    Description = "Description 2",
                    Point = 4,
                    Created = DateTime.Now,
                    IsDeleted = false
                },
                new Rating
                {
                    Id = Guid.NewGuid(),
                    OrderID = Guid.Parse("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                    Description = "Description 3",
                    Point = 3,
                    Created = DateTime.Now,
                    IsDeleted = false
                }
                );

            // Report Seed Data, 3 Reports
            /*builder.Entity<Report>()
               .HasData(
               new Report
               {
                   Id = Guid.NewGuid(),
                   UserAccountID = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                   UserAccountIDReport = "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                   Description = "Description 1",
                   Created = DateTime.Now,
                   IsDeleted = false
               },
               new Report
               {
                   Id = Guid.NewGuid(),
                   UserAccountID = "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                   UserAccountIDReport = "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                   Description = "Description 2",
                   Created = DateTime.Now,
                   IsDeleted = false
               },
               new Report
               {
                   Id = Guid.NewGuid(),
                   UserAccountID = "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                   UserAccountIDReport = "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                   Description = "Description 3",
                   Created = DateTime.Now,
                   IsDeleted = false
               }
               );*/

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEvents(this);

            return await base.SaveChangesAsync(cancellationToken);
        }

        public void SaveChanges()
        {
             _mediator.DispatchDomainEvents(this);

             base.SaveChanges();
        }

        public DbSet<T> Get<T>() where T : BaseAuditableEntity => Set<T>();
        public DbSet<T> GetUser<T>() where T : IdentityUser => Set<T>();
    }
}
