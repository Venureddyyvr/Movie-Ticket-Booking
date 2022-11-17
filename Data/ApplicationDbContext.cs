using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineMovieTicketBooking.Models;

namespace OnlineMovieTicketBooking.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BookingTable> BookingTable { get; set;}
        public DbSet<Cart> Cart { get; set;}
        public DbSet<MovieDetails> MovieDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)

        {

            base.OnModelCreating(builder);

        }
    }
}