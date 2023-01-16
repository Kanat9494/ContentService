namespace ContentService.Models;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }

    public DbSet<PopularProduct> PopularProducts { get; set; }
}
