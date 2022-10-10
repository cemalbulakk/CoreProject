using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Policy : BaseEntity
    {
        public int PolicyId { get; set; }
        public int? FileId { get; set; }
        public string? PolicyNo { get; set; }
        public string? PolicyAddNo { get; set; }
        public string? RenewalNumber { get; set; }
        public string? ProductName { get; set; }
        public DateTime? PolicyStartDate { get; set; }
        public DateTime? PolicyEndDate { get; set; }
        public DateTime? PolicyArrangementDate { get; set; }
        public string? TariffCode { get; set; }
        public string? AdendumNumber { get; set; }
        public DateTime? AdendumDate { get; set; }
        public int? AgencyId { get; set; }
        public string? ProfessionDiscountCode { get; set; }
        public string? ProfessionName { get; set; }
        public int? SparePartType { get; set; }
        public bool? Pledge { get; set; }
        public string? PledgeOwner { get; set; }
        public string? PledgeDescription { get; set; }
        public decimal? CommodityPrice { get; set; }
        public decimal? AccidentMaterial { get; set; }
        public decimal? MaterialPerVehicle { get; set; }
        public decimal? AccidentPerMaterial { get; set; }
        public decimal? TreatmentPerPerson { get; set; }
        public decimal? InjuryDeathPerPerson { get; set; }
        public decimal? InjuryDeathsPerAccident { get; set; }
        public string? Insurer { get; set; }
        public decimal? ExemptionRate { get; set; }
        public string? RepairPlace { get; set; }
        public decimal? InflationKloz { get; set; }
        public decimal? DiscretionaryLiability { get; set; }
        public decimal? YearlyGuaranteeLimit { get; set; }
        public decimal? Exemption { get; set; }
        public decimal? ExemptionAmount { get; set; }
        public decimal? TotalInsuranceFee { get; set; }
        public decimal? AdditionalHardwareFee { get; set; }
        public decimal? VehicleCost { get; set; }
        public decimal? VehicleBodyFee { get; set; }
    }
}
