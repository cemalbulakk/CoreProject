using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class AddressType : BaseEntity
    {
        public int AddressTypeId { get; set; }
        public string? AddressTypeName { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
