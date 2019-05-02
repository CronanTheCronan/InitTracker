using InitTrackerApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InitTrackerApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Conditions> Conditions { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<HeroGroups> HeroGroups { get; set; }
        public virtual DbSet<Heroes> Heroes { get; set; }
        public virtual DbSet<HeroesExtended> HeroesExtended { get; set; }
        public virtual DbSet<HeroesGroupXref> HeroesGroupXref { get; set; }
        public virtual DbSet<MonsterGroups> MonsterGroups { get; set; }
        public virtual DbSet<Monsters> Monsters { get; set; }
        public virtual DbSet<MonstersExtended> MonstersExtended { get; set; }
        public virtual DbSet<MonstersGroupXref> MonstersGroupXref { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=InitiativeTracker;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Conditions>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeroGroups>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Heroes>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.Heroes)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Heroes_Users");
            });

            modelBuilder.Entity<HeroesExtended>(entity =>
            {
                entity.Property(e => e.CurrentHp).HasColumnName("CurrentHP");

                entity.Property(e => e.MaxHp).HasColumnName("MaxHP");

                entity.HasOne(d => d.Hero)
                    .WithMany(p => p.HeroesExtended)
                    .HasForeignKey(d => d.HeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeroesExtended_Heroes");
            });

            modelBuilder.Entity<HeroesGroupXref>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.HeroesGroupXref)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeroesGroupXref_HeroGroups");

                entity.HasOne(d => d.HeroExt)
                    .WithMany(p => p.HeroesGroupXref)
                    .HasForeignKey(d => d.HeroExtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeroesGroupXref_HeroesExtended");

                entity.HasOne(d => d.Hero)
                    .WithMany(p => p.HeroesGroupXref)
                    .HasForeignKey(d => d.HeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeroesGroupXref_Heroes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HeroesGroupXref)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeroesGroupXref_Users");
            });

            modelBuilder.Entity<MonsterGroups>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Monsters>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecAc).HasColumnName("RecAC");

                entity.Property(e => e.RecHp).HasColumnName("RecHP");

                entity.HasOne(d => d.CreatedByUserNavigation)
                    .WithMany(p => p.Monsters)
                    .HasForeignKey(d => d.CreatedByUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Monsters_User");
            });

            modelBuilder.Entity<MonstersExtended>(entity =>
            {
                entity.Property(e => e.CurrentHp).HasColumnName("CurrentHP");

                entity.Property(e => e.MaxHp).HasColumnName("MaxHP");

                entity.HasOne(d => d.Monster)
                    .WithMany(p => p.MonstersExtended)
                    .HasForeignKey(d => d.MonsterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MonstersExtended_Monsters");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.PasswordSalt).IsRequired();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}