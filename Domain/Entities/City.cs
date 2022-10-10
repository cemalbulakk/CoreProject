using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class City : BaseEntity
    {
        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<District> Districts { get; set; }
    }
}
