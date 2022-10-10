using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Vehicle : BaseEntity
    {
        public int VehicleId { get; set; }
        public int? PersonTypeId { get; set; }
        public int? ClaimId { get; set; }
        public Claim Claim { get; set; }
        public int? PersonId { get; set; }
        public Person Person { get; set; }
        public int? VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public int? VehicleUsageTypeId { get; set; }
        public VehicleUsageType VehicleUsageType { get; set; }
        public int? VehicleBrandId { get; set; }
        public int? VehicleBrandTypeId { get; set; }
        public int? VehicleVariantId { get; set; }
        public int? VehicleModelYear { get; set; }
        public int? VehiclePlateCityId { get; set; }
        public bool? VehicleForeignPlate { get; set; }
        public string? VehiclePlateNumber { get; set; }
        public string? VehicleChassisNumber { get; set; }
        public string? VehicleMotorNumber { get; set; }
        public string? VehicleRegistrationSerialNo { get; set; }
        public string? VehicleKm { get; set; }
        public DateTime? VehicleTrafficReleaseDate { get; set; }
        public decimal? VehicleLoadLimit { get; set; }
        public int? VehicleWeight { get; set; }
        public int? ColourId { get; set; }
        public string? UmcCode { get; set; }
        public int? GtbrandId { get; set; }
        public int? GtmodelId { get; set; }
        public int? GtmotorId { get; set; }
        public int? GtgearBoxId { get; set; }
        public int? GtbodyId { get; set; }
        public string? GtestimateNumber { get; set; }
        public bool? ChassisSolutionControl { get; set; }
        public string? VehicleRegistrationSerialCode { get; set; }
        public int? VehicleClassId { get; set; }
        public decimal? SalvagePrice { get; set; }
        public decimal? MarketPrice { get; set; }
        public bool? VehicleRegistrationCertificate { get; set; }
        public string? GraphicalInterfaceLink { get; set; }
        public int? GraphicalInterfaceId { get; set; }
        public string? GtlabourGraphicUrl { get; set; }
        public string? GtlabourEstimateNumber { get; set; }
        public bool? Vinquery { get; set; }
        public bool? VinqueryBrand { get; set; }
        public string? GtmodelLevel { get; set; }
        public string? LicensedTemporaryStorage { get; set; }
        public DateTime? LicensedTemporaryStorageDeliveryDate { get; set; }
        public string? LicensedProcessingFacilityName { get; set; }
        public DateTime? LicensedProcessingFacilityDate { get; set; }
        public bool? CertificateOfWithdrawalFromTraffic { get; set; }
        public string? TrafficPullDocumentNumber { get; set; }
        public DateTime? TrafficPullDate { get; set; }
        public string? RepairTime { get; set; }
        public bool? Scrap { get; set; }
        public bool? FileManagerScrap { get; set; }
    }
}
