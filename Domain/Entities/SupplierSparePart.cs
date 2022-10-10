using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class SupplierSparePart : BaseEntity
    {
        public int SupplierSparePartId { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int SparePartId { get; set; }
        public SparePart SparePart { get; set; }
        public string SupplierPartCode { get; set; } = null!;
        public string FollowMainNumber { get; set; } = null!;
        public int ProductBrandId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public string Origin { get; set; } = null!;
        public decimal Price { get; set; }
        public string DiscountType { get; set; } = null!;
        public int CurrencyId { get; set; }
        public string CertificationInstitutionName { get; set; } = null!;
        public string BrandQualityDocumentNumber { get; set; } = null!;
        public string ProductEquivalentCertificateNumber { get; set; } = null!;
        public DateTime DocumentIssueDate { get; set; }
        public string DocumentEndDate { get; set; } = null!;
    }
}
