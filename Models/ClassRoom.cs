using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DarAlArqamForm.Models
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }
        public string Name { get; set; }

        //one to many with students
        public ICollection<Student> Students { get; set; }

        //one to one with Teacher
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }//will show data related to Teacher in classroom 
        
        public Branch Branch { get; set; }
        [ForeignKey("Branch")]
        public int BranchId { get; set; }
    }
}


