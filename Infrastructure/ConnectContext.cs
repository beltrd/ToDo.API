using Microsoft.EntityFrameworkCore;
using ToDo.API.Models;

namespace ToDo.API.Infrastructure
{
    public class ConnectContext : DbContext
    {
        public DbSet<GroupConnect> GroupConnect { get; set; }

        public ConnectContext (DbContextOptions<ConnectContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<GroupConnect>().HasData(
                new GroupConnect{
                    Id = 1,
                    GroupName = "diego1",
                    Connection = "server=localhost;port=3306;database=diegoDB1;user=diego_web;password=xQvy1Jc502rFbldI7ZoivIWk;"
                },
                new GroupConnect{
                    Id = 2,
                    GroupName = "diego2",
                    Connection = "server=localhost;port=3306;database=diegoDB2;user=diego_web;password=xQvy1Jc502rFbldI7ZoivIWk;"
                }
            );
        }
    }
}