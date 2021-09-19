using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CarRegistration.DataAccessLayer.DataModels
{
    public partial class CarDbContext : DbContext
    {
        public CarDbContext()
        {
        }

        public CarDbContext(DbContextOptions<CarDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarDevelorer> CarDevelorers { get; set; }
        public virtual DbSet<CarModel> CarModels { get; set; }
        public virtual DbSet<Develorer> Develorers { get; set; }
        public virtual DbSet<EngineType> EngineTypes { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder
        //        .UseLazyLoadingProxies()
        //        .UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=Car;Trusted_Connection=True;");
        //    }
        //    optionsBuilder.LogTo(System.Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name });
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasIndex(e => e.OwnerId, "idx_Owner");

                entity.Property(e => e.OwnerId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CarModel)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CarModelId)
                    .HasConstraintName("FK__Cars__CarModelId__286302EC");

                entity.HasOne(d => d.EngineType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.EngineTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cars__EngineType__276EDEB3");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cars__OwnerId__6383C8BA");
            });

            modelBuilder.Entity<CarDevelorer>(entity =>
            {
                entity.HasKey(e => new { e.DevelorerId, e.CarId })
                    .HasName("PK__CarDevel__CBB43AC7AAFCFC7C");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.CarDevelorers)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CarDevelo__CarId__1DB06A4F");

                entity.HasOne(d => d.Develorer)
                    .WithMany(p => p.CarDevelorers)
                    .HasForeignKey(d => d.DevelorerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CarDevelo__Devel__1CBC4616");
            });

            modelBuilder.Entity<CarModel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Develorer>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<EngineType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Changes)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
