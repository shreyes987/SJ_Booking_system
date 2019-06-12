namespace WindowsFormsApp6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Dbmodel : DbContext
    {
        public Dbmodel()
            : base("name=DbEntities")
        {
        }

        public virtual DbSet<customer> customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<customer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.TicketsNo)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.From)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.To)
                .IsUnicode(false);
        }
    }
}
