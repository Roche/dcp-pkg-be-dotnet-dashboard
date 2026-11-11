using System;
using System.ComponentModel.DataAnnotations;

namespace OpenDCP.Framework.Dashboard.Models
{
    public class DashboardExportDTO
    {
        public Guid Id { get; set; }
        public Guid TabId { get; set; }
        public short TabVersion { get; set; }
        [StringLength(250)]
        public string TabName { get; set; }
        public int SiteId { get; set; }
        public DateTime ExportDate { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int? OwnerUserId { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
