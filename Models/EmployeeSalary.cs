using System;

namespace DarAlArqamForm.Models
{
    public class EmployeeSalary
    {
        public int EmployeeSalaryId { get; set; }
        public Employee  Employee { get; set; }
        public int EmployeeId { get; set; }
        public DateTime SalaryYearMonth { get; set; }  
        public bool IsPaid { get; set; }
    }
}
