using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DarAlArqamForm.Models
{
    public class Student
    { 
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        /* public bool IsPayed { get; set; }*/
        // [Column(TypeName = "decimal(18,2)")]
        //public decimal AddedPaidValue { get; set; } //to make that ,involve create year

        //[Column(TypeName = "decimal(18,2)")]
         //public decimal PaymentValue { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Level Level { get; set; }
        [ForeignKey("Level")]
        public int LevelId { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        [ForeignKey("ClassRoom")]
        public int ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public decimal studentpay { get; set; }
        //public StudentPayment StudentPayment { get; set; }
        public ICollection<StudentMaterial> StudentMaterials { get; set; } 


    }
}

 