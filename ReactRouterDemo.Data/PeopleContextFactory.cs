﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ReactRouterDemo.Data
{
    public class PeopleContextFactory : IDesignTimeDbContextFactory<PeopleDataContext>
    {
        public PeopleDataContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), $"..{Path.DirectorySeparatorChar}ReactRouterDemo.Web"))
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true).Build();

            return new PeopleDataContext(config.GetConnectionString("ConStr"));
        }
    }
}