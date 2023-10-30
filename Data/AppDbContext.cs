using Microsoft.EntityFrameworkCore;

namespace fundamentos_aspnet.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=app.db;Cache=Shared");
    }
}
