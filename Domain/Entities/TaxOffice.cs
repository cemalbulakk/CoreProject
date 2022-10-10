using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TaxOffice : BaseEntity
    {
        public int TaxOfficeId { get; set; }
        public string TaxOfficeCode { get; set; } = null!;
        public string TaxOfficeName { get; set; } = null!;
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
