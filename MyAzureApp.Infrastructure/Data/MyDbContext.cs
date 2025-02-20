

using Microsoft.EntityFrameworkCore;
using MyAzureApp.Domain.Entities;

namespace MyAzureApp.Infrastructure.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
