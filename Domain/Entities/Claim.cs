using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Claim : BaseEntity
    {
        public int ClaimId { get; set; }
        public int? FileId { get; set; }
        public File File { get; set; }
        public int? ClaimStatusId { get; set; }
        public int? SubClaimStatusId { get; set; }
        public int? ExternalSystemId { get; set; }
        public int? ClaimOrderNo { get; set; }
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }
        public DamageCause DamageCause { get; set; }
        public int DamageCauseId { get; set; }
        public int? FormOfDamageId { get; set; }
        public int? DamageTypeId { get; set; }
        public DamageType DamageType { get; set; }
        public DateTime? ClaimDate { get; set; }
        public string? ClaimTime { get; set; }
        public string? GuaranteeOrderNo { get; set; }
        public int? CompensationClaimTypeId { get; set; }
        public decimal? OutstandingDamage { get; set; }
        public int? AbuseStatusId { get; set; }
        public int? ClaimEntryType { get; set; }
        public bool? Suspect { get; set; }
        public string? SuspectCause { get; set; }
        public int? SubGuaranteeType { get; set; }
        public int? GuaranteeCodeId { get; set; }
        public decimal? DepreciationAmount { get; set; }
        public bool? Depreciation { get; set; }
        public bool? PayImmediately { get; set; }
        public bool? PhysicalFile { get; set; }
        public decimal? PhysicalFileAmount { get; set; }
        public string? SbmtransactionRefNo { get; set; }
        public int? SbmexpertAssignmentStatusId { get; set; }
        public int? InformantType { get; set; }
        public bool? Research { get; set; }
        public bool? RemoteDamage { get; set; }
        public DateTime? ExpertiseRequestDate { get; set; }
        public DateTime? ExpertiseDate { get; set; }
    }
}
