namespace memory_game_backend.Data.Databases;

using Microsoft.EntityFrameworkCore;

using memory_game_backend.Models.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Score> Scores { get; set; }
}
