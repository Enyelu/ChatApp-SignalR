using ChatApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SignalRDemo.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<AppUser> AppUsers;
        public DbSet<Message> Messages;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    }
}