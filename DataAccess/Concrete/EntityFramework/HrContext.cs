using Core.Entities.Concrete;
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

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeFamily> EmployeeFamilies { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DbSet<EmployeeLanguage> EmployeeLanguages { get; set; }
        public DbSet<EmployeeDebit> EmployeeDebits { get; set; }
        public DbSet<EmployeeVacation> EmployeeVacations { get; set; }
        public DbSet<EmployeeComputerInformation> EmployeeComputerInformations { get; set; }
        public DbSet<EmployeeEmergencyInformation> EmployeeEmergencyInformations { get; set; }
        public DbSet<EmployeeContactInformation> EmployeeContactInformations { get; set; }
        public DbSet<EmployeePastWorkExperience> EmployeePastWorkExperiences { get; set; }
        public DbSet<EmployeeAwardInformation> EmployeeAwardInformations { get; set; }
        public DbSet<EducationaLevel> EducationaLevels { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<DebitType> DebitTypes { get; set; }
        public DbSet<AllowanceType> AllowanceTypes { get; set; }
        public DbSet<TypeOfAward> TypesOfAwards { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}