using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1.Configurations
{
    public class Stud_CourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> SC)
        {
            SC.HasKey(T => new { T.Stud_Id, T.Course_Id });

            SC
                .HasOne(sc => sc.Student)
                .WithMany(s => s.stud_courses)
                .HasForeignKey(sc => sc.Stud_Id)
                .OnDelete(DeleteBehavior.Restrict);

            SC
                .HasOne(sc => sc.Course)
                .WithMany(c => c.stud_courses)
                .HasForeignKey(sc => sc.Course_Id)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
