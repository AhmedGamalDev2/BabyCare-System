using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarAlArqamForm.Models
{
    public class TeacherSalary
    {
        public int TeacherSalaryId { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public DateTime SalaryYearMonth { get; set; }
        public bool IsPaid { get; set; }


    }
}
