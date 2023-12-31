using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarAlArqamForm.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        [DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18,2)")]
        public decimal Fees { get; set; }//students
        [DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18,2)")]
        public decimal EmployeeSalary { get; set; }
        [DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18,2)")]
        public decimal TeacherSalary { get; set; }
        [DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18,2)")]
        public decimal Donation { get; set; }
        [DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }
        //[ForeignKey("DarBalance")]
        //public int DarBalanceId { get; set; }
        //public DarBalance DarBalance { get; set; }
        
        
        // public DateTime month { get; set; }
      
    }
}
