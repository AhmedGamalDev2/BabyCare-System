using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DarAlArqamForm.Models
{
    public class StudentPayment
    {
        public int StudentPaymentId { get; set; }
        public Student Student { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }//may be OnDelete should be cascade
        public DateTime paymentYear { get; set; }//2020,2021,2022
        //public decimal AllPaidValue { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        public decimal AddPaidValue { get; set; }//value that paid from payment 
                                                 //public int RestValue { get; set; }//value that not paid from payment
     
    }
}
