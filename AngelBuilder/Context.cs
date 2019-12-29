using Microsoft.EntityFrameworkCore;

namespace AngelBuilder
{
    public class Context : DbContext
    {
        public DbSet<Unit> Units { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Ability> Abilities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlite("Data Source=darkangels.db;");
        }
    }
}
