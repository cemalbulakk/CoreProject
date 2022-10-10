using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Report : BaseEntity
    {
        public int ReportId { get; set; }
        public int? ClaimId { get; set; }
        public int? ActorFirmId { get; set; }
        public string? ReportNo { get; set; }
        public int? ReportType { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? ReportUrl { get; set; }
        public bool? ReportCancel { get; set; }
        public string? TramerTrackingNumber { get; set; }
        public DateTime? TramerApprovalDate { get; set; }
        public string? TramerReportNo { get; set; }
    }
}
