using EscapeRooms.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EscapeRooms.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)

        {
        }
         public DbSet<Reservation>? Reservation { get; set; }
        public DbSet<Room>? Room { get; set; }
        public DbSet<AppUser>? AppUser { get; set; }
    }
}