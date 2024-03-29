﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebLibrary.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Instruct> Instructs { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Learner> Learners { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-DT9JEAJM\\SQLEXPRESS;Database=Project_Group03;uid=sa;pwd=12345;encrypt=true;trustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.AdminId).HasColumnName("adminID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .HasColumnName("category_name");

                entity.Property(e => e.Description)
                    .HasColumnType("ntext")
                    .HasColumnName("description");
            });

            modelBuilder.Entity<Chapter>(entity =>
            {
                entity.ToTable("chapter");

                entity.Property(e => e.ChapterId).HasColumnName("chapterID");

                entity.Property(e => e.ChapterName)
                    .HasMaxLength(50)
                    .HasColumnName("chapter_name");

                entity.Property(e => e.CourseId).HasColumnName("courseID");

                entity.Property(e => e.Description)
                    .HasColumnType("ntext")
                    .HasColumnName("description");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.TotalTime)
                    .HasColumnName("total_time")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Chapters)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__chapter__courseI__48CFD27E");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("courses");

                entity.Property(e => e.CourseId).HasColumnName("courseID");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(255)
                    .HasColumnName("course_name");

                entity.Property(e => e.Description)
                    .HasColumnType("ntext")
                    .HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.Picture)
                    .HasColumnType("text")
                    .HasColumnName("picture");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status");

                entity.Property(e => e.TotalTime)
                    .HasColumnName("total_time")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__courses__categor__403A8C7D");
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.ToTable("enrollment");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EnrollmentDate).HasColumnType("datetime");

                entity.Property(e => e.LearnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Enrollments)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__enrollmen__Cours__5DCAEF64");

                entity.HasOne(d => d.Learner)
                    .WithMany(p => p.Enrollments)
                    .HasForeignKey(d => d.LearnerId)
                    .HasConstraintName("FK__enrollmen__Learn__5CD6CB2B");
            });

            modelBuilder.Entity<Instruct>(entity =>
            {
                entity.ToTable("instruct");

                entity.HasIndex(e => new { e.InstructorId, e.CourseId }, "UQ__instruct__029B7EDAD97979E6")
                    .IsUnique();

                entity.Property(e => e.InstructId).HasColumnName("instructID");

                entity.Property(e => e.CourseId).HasColumnName("courseID");

                entity.Property(e => e.InstructorId).HasColumnName("instructorID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Instructs)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__instruct__course__44FF419A");

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.Instructs)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK__instruct__instru__440B1D61");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("instructor");

                entity.Property(e => e.InstructorId).HasColumnName("instructorID");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.Income)
                    .HasColumnType("money")
                    .HasColumnName("income");

                entity.Property(e => e.Introduce)
                    .HasColumnType("ntext")
                    .HasColumnName("introduce");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Picture)
                    .HasColumnType("text")
                    .HasColumnName("picture");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("registration_Date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Learner>(entity =>
            {
                entity.ToTable("learner");

                entity.Property(e => e.LearnerId).HasColumnName("learnerID");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Picture)
                    .HasColumnType("text")
                    .HasColumnName("picture");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("registration_Date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Wallet)
                    .HasColumnType("money")
                    .HasColumnName("wallet");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.ToTable("lesson");

                entity.Property(e => e.LessonId).HasColumnName("lessonID");

                entity.Property(e => e.ChapterId).HasColumnName("chapterID");

                entity.Property(e => e.Content)
                    .HasColumnType("ntext")
                    .HasColumnName("content");

                entity.Property(e => e.CourseId).HasColumnName("courseID");

                entity.Property(e => e.Description)
                    .HasColumnType("ntext")
                    .HasColumnName("description");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.LessonName)
                    .HasMaxLength(50)
                    .HasColumnName("lesson_name");

                entity.Property(e => e.MustBeCompleted)
                    .HasColumnName("must_be_completed")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PercentToPassed)
                    .HasColumnName("percent_to_passed")
                    .HasDefaultValueSql("((80))");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.Chapter)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.ChapterId)
                    .HasConstraintName("FK__lesson__chapterI__4E88ABD4");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__lesson__courseID__4F7CD00D");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("review");

                entity.Property(e => e.ReviewId).HasColumnName("reviewID");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CourseId).HasColumnName("courseID");

                entity.Property(e => e.LearnerId).HasColumnName("learnerID");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("date")
                    .HasColumnName("review_date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__review__courseID__534D60F1");

                entity.HasOne(d => d.Learner)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.LearnerId)
                    .HasConstraintName("FK__review__learnerI__5441852A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
