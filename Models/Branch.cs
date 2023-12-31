using System.Collections.Generic;

namespace DarAlArqamForm.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<ClassRoom> ClassRooms { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

    }
}
