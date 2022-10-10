using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Country : BaseEntity
    {
        public int CountryId { get; set; }
        public string CountryCode { get; set; } = null!;
        public string CountryName { get; set; } = null!;

        public ICollection<City> Cities { get; set; }
    }
}
