using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ContractWorkTypeBrandAssignment : BaseEntity
    {
        public int ContractWorkTypeBrandAssignmentId { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public int WorkTypeId { get; set; }
        public decimal Discount { get; set; }
        public decimal SparePartDiscount { get; set; }
        public decimal RepairDiscount { get; set; }
    }
}
