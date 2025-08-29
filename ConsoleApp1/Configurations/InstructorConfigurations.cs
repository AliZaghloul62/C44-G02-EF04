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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I
                .Property(I => I.Salary)
                .HasColumnType("decimal(10,2)");
            I
                .Property(I => I.HourRateBouns)
                .HasColumnType("decimal(10,2)");

            I
                .HasOne(I => I.MangedDepartment)
                .WithOne(D => D.Manager)
                .HasForeignKey<Department>(D => D.Ins_ID)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
