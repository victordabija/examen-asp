using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LaptopStore.Models;

namespace LaptopStore.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<LaptopStore.Models.Client> Client { get; set; } = default!;

    public DbSet<LaptopStore.Models.Laptop> Laptop { get; set; } = default!;

    public DbSet<LaptopStore.Models.Manufacturer> Manufacturer { get; set; } = default!;
}