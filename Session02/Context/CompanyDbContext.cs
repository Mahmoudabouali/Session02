using Microsoft.EntityFrameworkCore;
using Session02.Configration;
using Session02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session02.Context
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder
            .UseSqlServer("server = .; database = CompanyDb011 ; trusted_Connection = true ; trust server certificate = true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EmployeeConfig());
            //modelBuilder.ApplyConfiguration(new DepartmentConfig());

            #region Many To Many
            modelBuilder.Entity<Student>()
                    .HasMany<Course>()
                    .WithMany()
                    .UsingEntity<CourseStudent>()
                    .HasKey(c => new { c.StudentId, c.CourseId }); 
            #endregion
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public DbSet<Employee> Employees {  get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }

    }
}
