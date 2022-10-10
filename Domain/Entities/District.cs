using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class District : BaseEntity
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}
