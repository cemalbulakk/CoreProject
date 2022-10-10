using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ProductBrand : BaseEntity
    {
        public int ProductBrandId { get; set; }
        public string ProductBrandName { get; set; } = null!;
        public int ProductBrandTypeId { get; set; }
        public ProductBrandType ProductBrandType { get; set; }
        public string CertificateUrl { get; set; } = null!;
    }
}
