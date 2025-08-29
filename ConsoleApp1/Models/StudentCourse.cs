using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    [PrimaryKey(nameof(Stud_Id), nameof(Course_Id))]
    public class StudentCourse
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        [Range(0, 100)]
        public int Grade { get; set; }

        public Course Course { get; set; } = null!;
        public Student Student { get; set; } = null!;
    }
}
