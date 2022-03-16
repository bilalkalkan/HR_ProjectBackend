using System;
using System.Text.Json.Serialization;
using Core.Entities;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime CompanyEntryDate { get; set; }
        public DateTime SGKEntryDate { get; set; }
        public DateTime AnnualLeaveEntitlementStartDate { get; set; }
        public string AnnualLeaveGroup { get; set; }
        public DateTime SeverancePayStartDate { get; set; }
        public DateTime OYAKStartDateOfWork { get; set; }
        public DateTime FirstDateOfJoiningTheGroup { get; set; }


        public decimal Wage { get; set; }
        public string TypeOfWage { get; set; }
        public string TypeOfPayment { get; set; }
        public string PaymentCurrency { get; set; }
    }
}