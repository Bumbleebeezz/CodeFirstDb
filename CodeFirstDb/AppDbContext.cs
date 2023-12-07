using Microsoft.EntityFrameworkCore;

namespace CodeFirstDb;

public class AppDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=MARIACONFIG;Initial Catalog=CodeFirstDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}