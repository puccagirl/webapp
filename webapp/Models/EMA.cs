namespace webapp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EMA : DbContext
    {
        public EMA()
            : base("name=EMA")
        {
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Event_Type> Event_Type { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Buildings)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event_Type>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Event_Type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.type)
                .IsFixedLength();
        }
    }
}
