using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Course_Inst
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        [Range(1, 10)]
        public int? Evaluate { get; set; }

        public Course Course { get; set; } = null!;
        public Instructor Instructor { get; set; } = null!;

    }
}
