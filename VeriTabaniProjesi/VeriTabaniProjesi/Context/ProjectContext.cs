using System;
using Microsoft.EntityFrameworkCore;
using VeriTabaniProjesi.Models;

namespace VeriTabaniProjesi.Context
{
    public class ProjectContext : DbContext
    {
        
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }
           
        public DbSet<Student> student { get; set; }
        public DbSet<Instructor> instructor { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<StudentCourse> studentcourse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // StudentCourse tablosu için sadece ID'leri kullanarak ilişki kuruyoruz
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.student_ID, sc.course_ID }); // student_ID ve course_ID'yi birleştirerek anahtar yapıyoruz

            // Burada artık öğrenci ve ders arasındaki ilişkileri kaldırıyoruz
            // student ve course ile ilişki tanımlamıyoruz.

            modelBuilder.Entity<Course>()
                .HasIndex(c => c.course_name)
                .IsUnique(); // Dersin adının benzersiz olmasını sağlıyoruz
        }
    }
}
