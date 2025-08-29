using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Range(1, int.MaxValue)]
        public int Duration { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; }

        public int Top_ID { get; set; }

        [InverseProperty(nameof(Topic.Courses))]
        public Topic Topic { get; set; } = null!;

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        [InverseProperty(nameof(StudentCourse.Course))]
        public ICollection<StudentCourse> stud_courses { get; set; } = new HashSet<StudentCourse>();

        [InverseProperty(nameof(Course_Inst.Course))]
        public ICollection<Course_Inst>? Course_Insts { get; set; } = new HashSet<Course_Inst>();


    }
}
