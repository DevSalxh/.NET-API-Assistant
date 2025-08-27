using Microsoft.EntityFrameworkCore;
/*
    |||
    |||
    ||| You have to add Microsoft.EntityFrameworkCore.Sqlite && Microsoft.EntityFrameworkCore.Design
    |||
    |||
*/
namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
