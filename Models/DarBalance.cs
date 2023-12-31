using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DarAlArqamForm.Models
{
    public class DarBalance
    {
        public int DarBalanceId { get; set; }
        [DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }
        [ForeignKey("Payment")]
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

    }
}
