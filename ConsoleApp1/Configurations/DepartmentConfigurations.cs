using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {

            D.Property(d => d.HiringDate)
             .HasConversion(
                 v => v.ToDateTime(TimeOnly.MinValue),  
                 v => DateOnly.FromDateTime(v)         
             );

            D.HasCheckConstraint("CK_Department_HiringDate", "HiringDate <= GETDATE()");

            
            D.HasOne(d => d.Manager)
             .WithOne(i => i.MangedDepartment)
             .HasForeignKey<Department>(d => d.Ins_ID)
             .OnDelete(DeleteBehavior.Restrict);

            D.HasMany(d => d.Instructors)
             .WithOne(i => i.InstructorDepartment)
             .HasForeignKey(i => i.Dept_ID)
             .OnDelete(DeleteBehavior.Restrict);

            D.HasMany(d => d.Students)
             .WithOne(s => s.Department)
             .HasForeignKey(s => s.Dep_Id)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
