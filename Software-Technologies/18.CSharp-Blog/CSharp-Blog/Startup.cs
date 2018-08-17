﻿using System.Data.Entity;
using CSharp_Blog.Migrations;
using CSharp_Blog.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharp_Blog.Startup))]
namespace CSharp_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext, Configuration>());
            ConfigureAuth(app);
        }
    }
}
