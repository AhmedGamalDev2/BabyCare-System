using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DarAlArqamForm.Models
{
    [Table("Teachers")]
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }//MonthlySalary
        //public bool IsPayed { get; set; }
        public ICollection<Student> Students { get; set; }

        //[ForeignKey("ClassRoom")]
        //public int ClassRoomId { get; set; }
        //public ClassRoom ClassRoom { get; set; }
        public Branch  Branch { get; set; }
        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        //public TeacherSalary TeacherSalary { get; set; }

    }
}
