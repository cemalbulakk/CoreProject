using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ClaimSparePart : BaseEntity
    {
        public int ClaimSparePartId { get; set; }
        public int? SparePartId { get; set; }
        public int? ClaimSparePartActorId { get; set; }
        public int? ClaimId { get; set; }
        public int? SupplierOutReasonId { get; set; }
        public string? SparePartCode { get; set; }
        public string? CupiCode { get; set; }
        public string? SparePartName { get; set; }
        public string? Description { get; set; }
        public int? DamageNo { get; set; }
        public decimal? Piece { get; set; }
        public decimal? InvoicePrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? SystemPrice { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxPrice { get; set; }
        public decimal? TaxTotal { get; set; }
        public decimal? TaxFreeTotal { get; set; }
        public decimal? KktRate { get; set; }
        public int? OperationType { get; set; }
        public int? SparePartType { get; set; }
        public bool? Supply { get; set; }
        public bool? Return { get; set; }
        public bool? MobileRepair { get; set; }
        public bool? Flag { get; set; }
        public int? SparePartEntryType { get; set; }
        public string? TedCamSparePartCode { get; set; }
        public int? DataProvider { get; set; }
        public int? ReportId { get; set; }
        public string? EquivalentBrand { get; set; }
        public int? PartFitType { get; set; }
        public int? AlternativeSparePartId { get; set; }
        public string? CountryName { get; set; }
        public string? Document { get; set; }
        public int? EquivalentReasonTypeId { get; set; }
    }
}
