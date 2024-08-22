using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02.Configration
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(d=> d.Name).HasMaxLength(20);

            #region one to one
            //builder.HasOne(d=> d.Maneger)
            //    .WithOne(e=> e.Department)
            //    .HasForeignKey<Department>(d=> d.MGID); 
            #endregion

            #region one to many
            //builder.HasMany<Employee>(d => d.Employees)
            //       .WithOne(e => e.Department)
            //       .HasForeignKey(e => e.DeptId); 
            #endregion

            #region two Relation
            //builder.HasOne<Employee>()
            //    .WithOne()
            //    .HasForeignKey<Department>(d => d.EmployeeId);
            //builder.HasMany<Employee>()
            //    .WithOne()
            //    .HasForeignKey(e => e.DepartmentId);
            #endregion
        }
    }
}
