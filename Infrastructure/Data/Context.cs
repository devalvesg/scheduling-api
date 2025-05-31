using Application.Contracts.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    internal class Context : DbContext, IContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
