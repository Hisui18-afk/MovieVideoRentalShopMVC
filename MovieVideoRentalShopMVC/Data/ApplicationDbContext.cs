using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieVideoRentalShopMVC.Models;

namespace MovieVideoRentalShopMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MovieVideoRentalShopMVC.Models.Customer> Customer { get; set; } = default!;
        public DbSet<MovieVideoRentalShopMVC.Models.Movie> Movie { get; set; } = default!;
        public DbSet<MovieVideoRentalShopMVC.Models.Rental> Rental { get; set; } = default!;
    }
}
