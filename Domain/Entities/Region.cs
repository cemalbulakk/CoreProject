using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Region : BaseEntity
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; } = null!;
        public string RegionCode { get; set; } = null!;
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
