using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Brand : BaseEntity
    {
        public int BrandId { get; set; }
        public string Code { get; set; } = null!;
        public string BrandName { get; set; } = null!;
    }
}
