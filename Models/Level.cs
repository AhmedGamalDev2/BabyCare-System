using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarAlArqamForm.Models
{
    public class Level
    {
        public int LevelId { get; set; }
        public string Name { get; set; }
        [ForeignKey("GeneralSetting")]
        public int GeneralSettingId { get; set; }//StudentPaymentValueId
        public GeneralSetting GeneralSetting { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
