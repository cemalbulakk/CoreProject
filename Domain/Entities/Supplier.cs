using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Supplier : BaseEntity
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public int SupplierTypeId { get; set; }
        public SupplierType SupplierType { get; set; }
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
        public string SupplierTitle { get; set; } = null!;
        public string SupplierInvoiceTitle { get; set; } = null!;
        public string CustomerCode { get; set; } = null!;
        public string Web { get; set; } = null!;
        public bool BusinessEnterprise { get; set; }
        public int TaxOfficeId { get; set; }
        public TaxOffice TaxOffice { get; set; }
        public string TaxNumber { get; set; } = null!;
        public int IdentityId { get; set; }
        public string RegistrationNumber { get; set; } = null!;
        public string CertificateNumber { get; set; } = null!;
        public int ParentSupplierId { get; set; }
    }
}
