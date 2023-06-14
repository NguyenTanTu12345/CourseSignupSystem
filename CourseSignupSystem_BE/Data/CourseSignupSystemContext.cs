using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CourseSignupSystem_BE.Models;

namespace CourseSignupSystem_BE.Data
{
    public partial class CourseSignupSystemContext : DbContext
    {
        public CourseSignupSystemContext()
        {
        }

        public CourseSignupSystemContext(DbContextOptions<CourseSignupSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<ClassStudent> ClassStudents { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<GroupSubject> GroupSubjects { get; set; } = null!;
        public virtual DbSet<Lecturer> Lecturers { get; set; } = null!;
        public virtual DbSet<SchoolYear> SchoolYears { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-RAH6IHC\\SQLEXPRESS;Initial Catalog=CourseSignupSystem;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassName).HasMaxLength(75);

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Descriptionz).HasMaxLength(300);

                entity.Property(e => e.FacultyName).HasMaxLength(75);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.SchoolYear)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.SchoolYearId)
                    .HasConstraintName("FK__Class__SchoolYea__286302EC");
            });

            modelBuilder.Entity<ClassStudent>(entity =>
            {
                entity.ToTable("ClassStudent");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassStudents)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__ClassStud__Class__34C8D9D1");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ClassStudents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__ClassStud__Stude__33D4B598");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Messagez).HasMaxLength(500);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GroupSubject>(entity =>
            {
                entity.ToTable("GroupSubject");

                entity.Property(e => e.GroupSubjectName).HasMaxLength(100);
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.ToTable("Lecturer");

                entity.Property(e => e.DateofBirth).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname).HasMaxLength(15);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.ImagePath).HasMaxLength(150);

                entity.Property(e => e.Lastname).HasMaxLength(35);

                entity.Property(e => e.LecturerAddress).HasMaxLength(100);

                entity.Property(e => e.LecturerPassword).HasMaxLength(50);

                entity.Property(e => e.MainSubject).HasMaxLength(75);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubSubject).HasMaxLength(75);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SchoolYear>(entity =>
            {
                entity.ToTable("SchoolYear");

                entity.Property(e => e.SchoolYearName).HasMaxLength(75);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateofBirth).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname).HasMaxLength(15);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.ImagePath).HasMaxLength(150);

                entity.Property(e => e.Lastname).HasMaxLength(35);

                entity.Property(e => e.Parent).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StudentAddress).HasMaxLength(100);

                entity.Property(e => e.StudentPassword).HasMaxLength(50);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.FacultyName).HasMaxLength(75);

                entity.Property(e => e.SubjectName).HasMaxLength(100);

                entity.HasOne(d => d.GroupSubject)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.GroupSubjectId)
                    .HasConstraintName("FK__Subjects__GroupS__2D27B809");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
