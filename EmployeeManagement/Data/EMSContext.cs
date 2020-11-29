using Microsoft.EntityFrameworkCore;

class EMSContext : DbContext
{
    public EMSContext(DbContextOptions<EMSContext> options) : base(options)
    {
    }
    public DbSet<Person> People { get; set; }
}