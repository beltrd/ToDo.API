using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDo.API.Models;

namespace ToDo.API.Infrastructure
{
    public class ToDoContext : DbContext 
    {
        public DbSet<ListModel> ListModel { get; set; }
        private ConnectContext _connectContext { get; set; }
        public ToDoContext (DbContextOptions<ToDoContext> options, ConnectContext connectContext = null) : base (options)
        {
            _connectContext = connectContext;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ListModel>().HasData(
                new ListModel{
                    Id = 1,
                    Name = "this name",
                    Item = "WOW"
                },
                new ListModel{
                    Id = 2,
                    Name = "this name",
                    Item = "WOW"
                }
            );
        }

        protected async override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // var connection = httpContext.Request.Headers["Connectionstring"];
            string groupName = "diego1";

            string conString =  await _connectContext.GroupConnect
                .Where(x => x.GroupName == groupName)
                .Select(x => x.Connection)
                .FirstOrDefaultAsync();

            options.UseMySql(conString);
            // await this.Database.EnsureCreatedAsync();
            await this.Database.MigrateAsync();
        }
    }
}