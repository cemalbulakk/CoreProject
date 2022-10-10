using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class SupplierLabor : BaseEntity
    {
        public int SupplierLaborId { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int LaborId { get; set; }
        public Labor Labor { get; set; }
        public decimal Price { get; set; }
    }
}
