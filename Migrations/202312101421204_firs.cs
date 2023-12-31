namespace DarAlArqamForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BranchId);
            
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        ClassRoomId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TeacherId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassRoomId)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        Phone = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        LevelId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        ClassRoomId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        studentpay = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.ClassRooms", t => t.ClassRoomId, cascadeDelete: false)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Levels", t => t.LevelId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.LevelId)
                .Index(t => t.TeacherId)
                .Index(t => t.BranchId)
                .Index(t => t.ClassRoomId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Levels",
                c => new
                    {
                        LevelId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GeneralSettingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LevelId)
                .ForeignKey("dbo.GeneralSettings", t => t.GeneralSettingId, cascadeDelete: true)
                .Index(t => t.GeneralSettingId);
            
            CreateTable(
                "dbo.GeneralSettings",
                c => new
                    {
                        GeneralSettingId = c.Int(nullable: false, identity: true),
                        PaymentValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AcceptanceDate = c.DateTime(nullable: false),
                        StudyEnd = c.DateTime(nullable: false),
                        YearAge = c.Int(nullable: false),
                        MonthAge = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GeneralSettingId);
            
            CreateTable(
                "dbo.StudentMaterials",
                c => new
                    {
                        StudentMaterialId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        MaterialId = c.Int(nullable: false),
                        ExamGrade = c.Double(nullable: false),
                        ExamDate = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StudentMaterialId)
                .ForeignKey("dbo.Materials", t => t.MaterialId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.MaterialId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MaxDegree = c.Int(nullable: false),
                        MinDegree = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaterialId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BranchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: false)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Costs",
                c => new
                    {
                        CostId = c.Int(nullable: false, identity: true),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CostId);
            
            CreateTable(
                "dbo.DarBalances",
                c => new
                    {
                        DarBalanceId = c.Int(nullable: false, identity: true),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DarBalanceId)
                .ForeignKey("dbo.Payments", t => t.PaymentId, cascadeDelete: true)
                .Index(t => t.PaymentId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Fees = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmployeeSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TeacherSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Donation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PaymentId);
            
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        DonationId = c.Int(nullable: false, identity: true),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DonationId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EmployeeSalaries",
                c => new
                    {
                        EmployeeSalaryId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        SalaryYearMonth = c.DateTime(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeSalaryId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.StudentPayments",
                c => new
                    {
                        StudentPaymentId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        paymentYear = c.DateTime(nullable: false),
                        AddPaidValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StudentPaymentId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.TeacherSalaries",
                c => new
                    {
                        TeacherSalaryId = c.Int(nullable: false, identity: true),
                        TeacherId = c.Int(nullable: false),
                        SalaryYearMonth = c.DateTime(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherSalaryId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherSalaries", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentPayments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.EmployeeSalaries", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.DarBalances", "PaymentId", "dbo.Payments");
            DropForeignKey("dbo.ClassRooms", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Students", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.StudentMaterials", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentMaterials", "MaterialId", "dbo.Materials");
            DropForeignKey("dbo.Students", "LevelId", "dbo.Levels");
            DropForeignKey("dbo.Levels", "GeneralSettingId", "dbo.GeneralSettings");
            DropForeignKey("dbo.Students", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Students", "ClassRoomId", "dbo.ClassRooms");
            DropForeignKey("dbo.Students", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.ClassRooms", "BranchId", "dbo.Branches");
            DropIndex("dbo.TeacherSalaries", new[] { "TeacherId" });
            DropIndex("dbo.StudentPayments", new[] { "StudentId" });
            DropIndex("dbo.EmployeeSalaries", new[] { "EmployeeId" });
            DropIndex("dbo.DarBalances", new[] { "PaymentId" });
            DropIndex("dbo.Teachers", new[] { "BranchId" });
            DropIndex("dbo.StudentMaterials", new[] { "MaterialId" });
            DropIndex("dbo.StudentMaterials", new[] { "StudentId" });
            DropIndex("dbo.Levels", new[] { "GeneralSettingId" });
            DropIndex("dbo.Students", new[] { "CountryId" });
            DropIndex("dbo.Students", new[] { "ClassRoomId" });
            DropIndex("dbo.Students", new[] { "BranchId" });
            DropIndex("dbo.Students", new[] { "TeacherId" });
            DropIndex("dbo.Students", new[] { "LevelId" });
            DropIndex("dbo.ClassRooms", new[] { "BranchId" });
            DropIndex("dbo.ClassRooms", new[] { "TeacherId" });
            DropTable("dbo.Users");
            DropTable("dbo.TeacherSalaries");
            DropTable("dbo.StudentPayments");
            DropTable("dbo.EmployeeSalaries");
            DropTable("dbo.Employees");
            DropTable("dbo.Donations");
            DropTable("dbo.Payments");
            DropTable("dbo.DarBalances");
            DropTable("dbo.Costs");
            DropTable("dbo.Teachers");
            DropTable("dbo.Materials");
            DropTable("dbo.StudentMaterials");
            DropTable("dbo.GeneralSettings");
            DropTable("dbo.Levels");
            DropTable("dbo.Countries");
            DropTable("dbo.Students");
            DropTable("dbo.ClassRooms");
            DropTable("dbo.Branches");
        }
    }
}
