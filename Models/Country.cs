using System.Collections.Generic;

namespace DarAlArqamForm.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> students { get; set; } 
    }
}
