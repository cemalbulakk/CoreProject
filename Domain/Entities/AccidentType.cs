using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class AccidentType : BaseEntity
    {
        public int AccidentTypeId { get; set; }
        public string AccidentTypeName { get; set; } = null!;
        public string Sbmcode { get; set; } = null!;
    }
}
