using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class File : BaseEntity
    {
        public int FileId { get; set; }
        public string? FileNo { get; set; }
        public int? FileType { get; set; }
        public int? PolicyId { get; set; }
        public DateTime? DamageDate { get; set; }
        public string? DamageTime { get; set; }
        public int? DamageCountryId { get; set; }
        public int? DamageCityId { get; set; }
        public int? DamageRegionId { get; set; }
        public int? DamageDistrictId { get; set; }
        public int? DamageTownId { get; set; }
        public string? DamagePlace { get; set; }
        public string? DamageForm { get; set; }
        public string? AccidentDetectionRecordNo { get; set; }
    }
}
