namespace Domain.Entities
{
    public partial class Address : BaseEntity
    {
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public AddressType AddressType { get; set; }
        public int AddressParentId { get; set; }
        public ParentType ParentType { get; set; }
        public int ParentTypeId { get; set; }
        public string AddressLine { get; set; }
        public string AddressLine2 { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public int TownId { get; set; }
        public Town Town { get; set; }
        public string PostalCode { get; set; }
    }
}
