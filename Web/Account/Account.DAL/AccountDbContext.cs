using Account.DAL.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Account.DAL
{
    // dotnet ef migrations add Account_migration --context AccountDbContext --project Account.DAL --verbose
    // dotnet ef database update --context AccountDbContext --project Account.DAL --verbose

    public class AccountDbContext : DbContext
    {
        public AccountDbContext()
        {
        }

        public AccountDbContext(DbContextOptions<AccountDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=Account;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(nameof(User));

                entity.Property(x => x.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable(nameof(Transaction));

                entity.Property(x => x.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();                

                entity.Property(x => x.Amount)
                    .IsRequired();

                entity.Property(x => x.Date)
                    .IsRequired();

                entity.HasOne(x => x.User)
                    .WithMany(x => x.Transactions)
                    .HasForeignKey(x => x.UserId);

                entity.HasKey(x => x.Id);
            });
        }
    }
}
