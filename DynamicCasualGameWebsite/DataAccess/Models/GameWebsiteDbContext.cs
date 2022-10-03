using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.Models
{
    public partial class GameWebsiteDbContext : DbContext
    {
        public GameWebsiteDbContext()
        {
        }

        public GameWebsiteDbContext(DbContextOptions<GameWebsiteDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Description> Descriptions { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=robot;database=GameWebsiteDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdAccount)
                    .HasName("PK__Account__B7B00CE38DFFBE95");

                entity.ToTable("Account");

                entity.Property(e => e.NameAccount).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(100);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("PK__Category__CBD74706A126B435");

                entity.ToTable("Category");

                entity.Property(e => e.NameCategory).HasMaxLength(20);
            });

            modelBuilder.Entity<Description>(entity =>
            {
                entity.HasKey(e => e.IdDescription)
                    .HasName("PK__Descript__D1FF265D9735C765");

                entity.ToTable("Description");

                entity.Property(e => e.Description1)
                    .HasMaxLength(500)
                    .HasColumnName("Description");

                entity.Property(e => e.Time).HasMaxLength(20);

                entity.HasOne(d => d.IdLessonNavigation)
                    .WithMany(p => p.Descriptions)
                    .HasForeignKey(d => d.IdLesson)
                    .HasConstraintName("FK__Descripti__IdLes__412EB0B6");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.IdFeedback)
                    .HasName("PK__Feedback__408FF103EEB79033");

                entity.ToTable("Feedback");

                entity.Property(e => e.LessonFeedback).HasMaxLength(500);

                entity.Property(e => e.PhoneNumber).HasMaxLength(15);

                entity.HasOne(d => d.IdLessonNavigation)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.IdLesson)
                    .HasConstraintName("FK__Feedback__IdLess__46E78A0C");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.HasKey(e => e.IdLesson)
                    .HasName("PK__Lesson__2253D85AC96AF018");

                entity.ToTable("Lesson");

                entity.Property(e => e.NameLesson).HasMaxLength(100);

                entity.Property(e => e.VideoUrl).HasMaxLength(300);

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK__Lesson__IdCatego__36B12243");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.IdQuestion)
                    .HasName("PK__Question__FB3BDD3021633DAD");

                entity.ToTable("Question");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(15);

                entity.Property(e => e.Question1)
                    .HasMaxLength(500)
                    .HasColumnName("Question");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
