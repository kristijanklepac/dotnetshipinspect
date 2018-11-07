using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASPNetCoreIdentityDemo.Models;

namespace ASPNetCoreIdentityDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Flag> Flags { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShipType> ShipTypes { get; set; }
        public DbSet<RecognizedOrganization> RecognizedOrganizations { get; set; }
        public DbSet<WGBList> WgbLists { get; set; }
        public DbSet<TokyoWgbList> TokyoWgbLists { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<ParisMouDeficiencyCode> ParisMouDeficiencyCodes { get; set; }
        public DbSet<IsmDeficiency> IsmDeficiencies { get; set; }
        public DbSet<RcaCode> RcaCodes { get; set; }
        public DbSet<ActionCode> Actions { get; set; }
        public DbSet<Accident> Accidents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<WGBList>()
            .HasIndex(u => u.WgbFlag)
            .IsUnique();

            builder.Entity<TokyoWgbList>()
            .HasIndex(u => u.WgbFlag)
            .IsUnique();

            builder.Entity<ParisMouDeficiencyCode>()
            .HasIndex(u => u.ThetisCode)
            .IsUnique();
        }
        

    }
}
