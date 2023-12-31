using System.ComponentModel.DataAnnotations.Schema;

namespace DarAlArqamForm.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        // [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }//MonthlySalary
        public EmployeeSalary  EmployeeSalary { get; }

    }
}






