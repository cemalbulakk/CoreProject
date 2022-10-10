using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Color : BaseEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; } = null!;
    }
}
