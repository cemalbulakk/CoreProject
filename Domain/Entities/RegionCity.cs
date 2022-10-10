using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class RegionCity : BaseEntity
    {
        public int RegionCityId { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
