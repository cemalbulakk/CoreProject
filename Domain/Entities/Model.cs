using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Model : BaseEntity
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; } = null!;
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int ModelYear { get; set; }
        public decimal MarketPrice { get; set; }
    }
}
