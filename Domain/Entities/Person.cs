using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Person : BaseEntity
    {
        public int PersonId { get; set; }
        public int? PersonTypeId { get; set; }
        public int? ClaimId { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? IdentityNumber { get; set; }
        public int? IdentityType { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? PhoneNumber1 { get; set; }
        public string? PhoneNumber2 { get; set; }
        public string? MobilePhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Iban { get; set; }
        public string? Address { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public int? TownId { get; set; }
        public int? BankId { get; set; }
        public int? BankBranchId { get; set; }
        public int? TaxCityId { get; set; }
        public int? TaxOfficeId { get; set; }
        public int? LicenseNo { get; set; }
        public DateTime? LicenseDate { get; set; }
        public int? LicenseCityId { get; set; }
        public int? LicenseDistrictId { get; set; }
        public int? LicenseClass { get; set; }
        public bool? LicenseEnough { get; set; }
        public bool? AlcoholStatus { get; set; }
        public decimal? AlcoholPromile { get; set; }
    }
}
