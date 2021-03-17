using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }

    //private const string Name = "DefaultConnection";
    // private readonly IConfiguration _config;

    // public Startup(IConfiguration config)
    // {
    //     _config = config;
    // }

}