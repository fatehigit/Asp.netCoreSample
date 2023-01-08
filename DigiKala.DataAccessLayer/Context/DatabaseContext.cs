//add this for DbContext
using DigiKala.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace DigiKala.DataAccessLayer.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            //in last Mvc:
            //Intial if dont exit
            //intial if nedeed fro update
            //call migration

            /*
                * before create db fro migration register context in startup and set connection string in appsettings.json file
                * tools>Nuget Package Maneger > ...Console
                PM> Enable-migrations
                Enable-Migrations is obsolete. Use Add-Migration to start using Migrations.
                PM> add-Migration Mig.InitialCreate
                Build started...
                Build succeeded.
                PM> Update-Database
                Build started...
                Build succeeded.
                Done.
                PM> 
             * */

        }

        //DbSet Place
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

