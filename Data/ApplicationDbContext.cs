using DarAlArqamForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarAlArqamForm.Data
{
    internal class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("name=DefaultConnection")
        {
            
        }

        public DbSet<Donation> Donations { get; set; }
        public DbSet<Teacher>  Teachers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DarBalance> DarBalances { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
        public DbSet<Level> levels { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<StudentMaterial> StudentMaterials { get; set; }
        public DbSet<StudentPayment> StudentPayments { get; set; }
        public DbSet<GeneralSetting> GeneralSettings { get; set; }
        public DbSet<TeacherSalary> TeacherSalaries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cost> Costs { get; set; }

     

    }
}
