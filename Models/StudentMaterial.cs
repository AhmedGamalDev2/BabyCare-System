using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DarAlArqamForm.Models
{
    public class StudentMaterial
    {

        public int StudentMaterialId { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }// may be OnDelete should be Restrect
        [ForeignKey("Material")]
        public int MaterialId { get; set; }
        public Student Student { get; set; }
        public Material Material { get; set; }
        public double ExamGrade { get; set; }
        public DateTime ExamDate { get; set; }
        public string Description { get; set; }
    }
}
