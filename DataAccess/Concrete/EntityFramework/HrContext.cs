﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class HrContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HR_Project;Trusted_Connection=true");
        }

        public DbSet<Employee>? Employees { get; set; }
        public DbSet<EmployeeFamily>? EmployeeFamilies { get; set; }
        public DbSet<EmployeeEducation>? EmployeeEducations { get; set; }
        public DbSet<EmployeeLanguage>? EmployeeLanguages { get; set; }
        public DbSet<EmployeeDebit>? EmployeeDebits { get; set; }
        public DbSet<EmployeeVacation>? EmployeeVacations { get; set; }
        DbSet<EducationaLevel>? EducationaLevels { get; set; }
        DbSet<FamilyMember>? FamilyMembers { get; set; }
        DbSet<Language>? Languages { get; set; }
        DbSet<Nationality>? Nationalities { get; set; }
        DbSet<DebitType>? DebitTypes { get; set; }
        DbSet<AllowanceType>? AllowanceTypes { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}