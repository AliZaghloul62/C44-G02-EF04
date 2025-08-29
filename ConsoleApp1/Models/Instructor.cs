using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(1, int.MaxValue)]
        public decimal Salary { get; set; }
        [MaxLength(150)]
        public string? Address { get; set; }
        [Range(0, int.MaxValue)]
        public decimal HourRateBouns { get; set; }
        [InverseProperty(nameof(Department.Manager))]
        public Department? MangedDepartment { get; set; }

        [InverseProperty(nameof(Department.Instructors))]
        public Department InstructorDepartment { get; set; } = null!;

        [ForeignKey(nameof(InstructorDepartment))]
        public int Dept_ID { get; set; }
        [InverseProperty(nameof(Course_Inst.Instructor))]
        public ICollection<Course_Inst>? Course_Insts { get; set; } = new HashSet<Course_Inst>();

    }
}
