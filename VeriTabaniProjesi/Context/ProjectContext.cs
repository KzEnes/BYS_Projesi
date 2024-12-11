using System;
using Microsoft.EntityFrameworkCore;
using VeriTabaniProjesi.Models;

namespace VeriTabaniProjesi.Context
{
    public class ProjectContext : DbContext
    {
        // Constructor: DbContextOptions kullanarak AppDbContext'i yapılandırıyoruz.
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        // Veritabanı tablolarını temsil eden DbSet'ler
        public DbSet<Student> student { get; set; }
        public DbSet<Instructor> instructor { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<StudentCourse> studentcourse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);  // Varsayılan yapılandırmaları uyguladı

            // StudentCourse Many-to-Many ilişkisinin yapılandırılması
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.student_ID, sc.course_ID }); // Bir öğrenci ve bir ders arasındaki ilişkiyi tekil hale getiriyor

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.student) // StudentCourse, bir Student'e sahip
                .WithMany(s => s.studentcourses) // Bir öğrenci birden fazla dersi seçebilir
                .HasForeignKey(sc => sc.student_ID); // Foreign Key olarak student_ID kullanılıyor

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.course) // StudentCourse, bir Course'a sahip
                .WithMany(c => c.studentcourses) // Bir ders birden fazla öğrenciye verilebilir
                .HasForeignKey(sc => sc.course_ID); // Foreign Key olarak course_ID kullanılıyor

            // Diğer özel ayarlar yapılabilir
            // Örneğin, Course'un adı benzersiz olsun:
            modelBuilder.Entity<Course>()
                .HasIndex(c => c.course_name)
                .IsUnique();
        }
    }
}
