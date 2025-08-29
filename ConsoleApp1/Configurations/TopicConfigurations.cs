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
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> T)
        {
            T.HasIndex(T => T.Name).IsUnique();

            T
                .HasMany(T => T.Courses)
                .WithOne(C => C.Topic)
                .HasForeignKey(C => C.Top_ID)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
