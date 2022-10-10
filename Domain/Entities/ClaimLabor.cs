using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ClaimLabor : BaseEntity
    {
        public int ClaimLaborId { get; set; }
        public int? ClaimId { get; set; }
        public int? SparePartId { get; set; }
        public string? Description { get; set; }
        public decimal? MechanicalPrice { get; set; }
        public decimal? ElectricityPrice { get; set; }
        public decimal? BodyworkPrice { get; set; }
        public decimal? FloorPrice { get; set; }
        public decimal? GlassPrice { get; set; }
        public decimal? PaintPrice { get; set; }
        public decimal? RepairPrice { get; set; }
        public string? PaintType { get; set; }
        public int? PaintScale { get; set; }
        public int? RepairScale { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxPrice { get; set; }
        public decimal? TaxTotal { get; set; }
        public decimal? TaxFreeTotal { get; set; }
        public string? Note { get; set; }
        public int? ReportId { get; set; }
        public int? LaborCostId { get; set; }
    }
}
