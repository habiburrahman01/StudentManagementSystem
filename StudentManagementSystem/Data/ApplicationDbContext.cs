using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudentManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .ToTable("Student")
                .Property(a => a.StudentName)
                .HasColumnType("varchar")
                .HasMaxLength(100);



            modelBuilder.Entity<StudentClass>()
                .ToTable("StudentClass")
                .Property(a => a.ClassName)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            modelBuilder.Entity<Student>()
                .HasOne(p => p.StudentClass)
                .WithMany(b => b.Students)
                .HasForeignKey(p => p.Class);

            base.OnModelCreating(modelBuilder);

        }



        public DbSet<StudentManagementSystem.Models.StudentClass> StudentClass{ get; set; }



        public DbSet<StudentManagementSystem.Models.Student> Student{ get; set; }
    }
}
