using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarAlArqamForm.Models
{
    public class GeneralSetting
    {
       
            public int GeneralSettingId { get; set; }
            public  decimal PaymentValue { get; set; }
            public DateTime AcceptanceDate { get; set; }
            public DateTime StudyEnd { get; set; }
            public int YearAge { get; set; }
            public int MonthAge { get; set; }

        
    }
}
