using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class DefinitionParameter : BaseEntity
    {
        public int DefinitionParameterId { get; set; }
        public int ParentId { get; set; }
        public int ParentTypeId { get; set; }
        public ParentType ParentType { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
    }
}
