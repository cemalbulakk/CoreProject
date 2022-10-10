using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TaxRate : BaseEntity
    {
        public int TaxRateId { get; set; }
        public int Rate { get; set; }
    }
}
