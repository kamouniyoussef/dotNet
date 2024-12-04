 
using dotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {



        }
        public DbSet<Client> Cliens { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Login> logins { get; set; }
        public DbSet<RegisterModel> registers { get; set; }

    }
}
