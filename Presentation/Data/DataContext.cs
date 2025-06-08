using Microsoft.EntityFrameworkCore;

namespace Presentation.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
    {
    public DbSet<TosEntity> TosServices { get; set; } = null!;
    }
