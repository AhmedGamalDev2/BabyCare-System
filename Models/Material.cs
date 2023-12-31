using System.Collections.Generic;

namespace DarAlArqamForm.Models
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public int MaxDegree { get; set; }
        public int MinDegree { get; set; }
        public ICollection<StudentMaterial> StudentMaterials { get; set; } = new HashSet<StudentMaterial>();
    }
}
