using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppConference
{
    public partial class ConferenceDbContext : DbContext
    {
        public ConferenceDbContext()
        {
        }

        public ConferenceDbContext(DbContextOptions<ConferenceDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Building> Buildings { get; set; } = null!;
        public virtual DbSet<Conference> Conferences { get; set; } = null!;
        public virtual DbSet<Equipment> Equipment { get; set; } = null!;
        public virtual DbSet<Leader> Leaders { get; set; } = null!;
        public virtual DbSet<Performance> Performances { get; set; } = null!;
        public virtual DbSet<Place> Places { get; set; } = null!;
        public virtual DbSet<Section> Sections { get; set; } = null!;
        public virtual DbSet<Speaker> Speakers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ConferenceDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__Building__737584F7D5D41689");

                entity.ToTable("Building");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Conference>(entity =>
            {
                entity.ToTable("Conference");

                entity.Property(e => e.BuildingName).HasMaxLength(100);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.BuildingNameNavigation)
                    .WithMany(p => p.Conferences)
                    .HasForeignKey(d => d.BuildingName)
                    .HasConstraintName("FK__Conferenc__Build__2B3F6F97");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Leader>(entity =>
            {
                entity.ToTable("Leader");

                entity.Property(e => e.Firstname).HasMaxLength(50);

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Middlename).HasMaxLength(50);
            });

            modelBuilder.Entity<Performance>(entity =>
            {
                entity.ToTable("Performance");

                entity.Property(e => e.DateTimeStart).HasColumnType("datetime");

                entity.Property(e => e.Theme).HasMaxLength(100);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Performances)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK__Performan__Secti__35BCFE0A");

                entity.HasOne(d => d.Speaker)
                    .WithMany(p => p.Performances)
                    .HasForeignKey(d => d.SpeakerId)
                    .HasConstraintName("FK__Performan__Speak__34C8D9D1");

                entity.HasMany(d => d.Equipment)
                    .WithMany(p => p.Performances)
                    .UsingEntity<Dictionary<string, object>>(
                        "PerformanceEquipment",
                        l => l.HasOne<Equipment>().WithMany().HasForeignKey("EquipmentId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Performan__Equip__398D8EEE"),
                        r => r.HasOne<Performance>().WithMany().HasForeignKey("PerformanceId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Performan__Perfo__38996AB5"),
                        j =>
                        {
                            j.HasKey("PerformanceId", "EquipmentId").HasName("PK__Performa__7A241A463D5F52B9");

                            j.ToTable("PerformanceEquipment");
                        });
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__Place__737584F758971490");

                entity.ToTable("Place");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Section");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PlaceName).HasMaxLength(100);

                entity.HasOne(d => d.Conference)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.ConferenceId)
                    .HasConstraintName("FK__Section__Confere__30F848ED");

                entity.HasOne(d => d.Leader)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.LeaderId)
                    .HasConstraintName("FK__Section__LeaderI__300424B4");

                entity.HasOne(d => d.PlaceNameNavigation)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.PlaceName)
                    .HasConstraintName("FK__Section__PlaceNa__31EC6D26");
            });

            modelBuilder.Entity<Speaker>(entity =>
            {
                entity.ToTable("Speaker");

                entity.Property(e => e.Biography).HasMaxLength(4000);

                entity.Property(e => e.Degree).HasMaxLength(100);

                entity.Property(e => e.Firstname).HasMaxLength(50);

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Middlename).HasMaxLength(50);

                entity.Property(e => e.PostName).HasMaxLength(100);

                entity.Property(e => e.Work).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
