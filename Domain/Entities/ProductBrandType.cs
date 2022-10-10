using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ProductBrandType : BaseEntity
    {
        public int ProductBrandTypeId { get; set; }
        public string ProductBrandTypeName { get; set; } = null!;
    }
}
