using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;


namespace Entities
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            
            var builder = new DbContextOptionsBuilder<RepositoryContext>();
            var connectionString = "Server=.\\SQLEXPRESS;Initial Catalog=RepoPattern;Integrated Security=False; uid=sa;password=123";
            builder.UseSqlServer(connectionString);
            return new RepositoryContext(builder.Options);
        }
    }

    public class RepositoryContext : DbContext
    {
        public RepositoryContext( DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}
