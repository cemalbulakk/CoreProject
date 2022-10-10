using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Payment : BaseEntity
    {
        public int? PaymentId { get; set; }
        public int? ClaimId { get; set; }
        public int? PaymentTypeId { get; set; }
        public string? DetailNumber { get; set; }
        public string? GuaranteeNumber { get; set; }
        public int? ActorTypeId { get; set; }
        public int? CreditorTypeId { get; set; }
        public int? CreditorIdentityTypeId { get; set; }
        public string? CreditorIdentityNumber { get; set; }
        public string? CreditorName { get; set; }
        public string? CreditorSurname { get; set; }
        public string? CreditorIbanNumber { get; set; }
        public DateTime? CreditorBirthDate { get; set; }
        public int? ActorFirmId { get; set; }
        public string? ActorCode { get; set; }
        public string? BranchOfficeCode { get; set; }
        public string? SourceCode { get; set; }
        public string? InvoiceNumber { get; set; }
        public DateTime? InvioceDate { get; set; }
        public string? InvoiceUrl { get; set; }
        public decimal? SparePartsTotal { get; set; }
        public decimal? LabourTotal { get; set; }
        public decimal? SparePartsKdvamount { get; set; }
        public decimal? LabourKdvamount { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ExemptionAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool? PaymentConfirm { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentStatusId { get; set; }
        public int? PaymentSubStatusId { get; set; }
        public decimal? ExpertAmount { get; set; }
        public decimal? ExpertCostAmount { get; set; }
        public decimal? CashFreeDiscount { get; set; }
        public decimal? DefectDiscountAmount { get; set; }
        public int? SubGuaranteeTypeId { get; set; }
        public int? TevkifatTypeId { get; set; }
        public bool? TevkifatCalculate { get; set; }
        public int? SparePartTevkifatRateId { get; set; }
        public decimal? SparePartTevkifatAmount { get; set; }
        public int? LabourTevkifatRateId { get; set; }
        public decimal? LabourTevkifatAmount { get; set; }
    }
}
