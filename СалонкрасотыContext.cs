using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SalonSaxap
{
    public partial class СалонкрасотыContext : DbContext
    {
        private static СалонкрасотыContext _context;
        internal object Uslugi;

        public static СалонкрасотыContext GetContext()
        {
            //СалонкрасотыContext db = new СалонкрасотыContext();
           if (_context == null)
              _context = new СалонкрасотыContext();
            return _context;
        }
        public СалонкрасотыContext()
        {
        }

        public СалонкрасотыContext(DbContextOptions<СалонкрасотыContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Uslugi> Uslugis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\айгуль\\Desktop\\Салон красоты.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entry>(entity =>
            {
                entity.HasKey(e => e.IdEntry);

                entity.ToTable("Entry");

                entity.HasIndex(e => e.IdEntry, "IX_Entry_id_entry")
                    .IsUnique();

                entity.Property(e => e.IdEntry).HasColumnName("id_entry");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdUslugi).HasColumnName("id_uslugi");

                entity.Property(e => e.Master)
                    .IsRequired()
                    .HasColumnName("master");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Entries)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdUslugiNavigation)
                    .WithMany(p => p.Entries)
                    .HasForeignKey(d => d.IdUslugi)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("User");

                entity.HasIndex(e => e.Email, "IX_User_email")
                    .IsUnique();

                entity.HasIndex(e => e.IdUser, "IX_User_id_user")
                    .IsUnique();

                entity.HasIndex(e => e.Login, "IX_User_login")
                    .IsUnique();

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasColumnName("fullname");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role");
            });

            modelBuilder.Entity<Uslugi>(entity =>
            {
                entity.HasKey(e => e.IdUslugi);

                entity.ToTable("Uslugi");

                entity.HasIndex(e => e.IdUslugi, "IX_Uslugi_id_uslugi")
                    .IsUnique();

                entity.Property(e => e.IdUslugi).HasColumnName("id_uslugi");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
