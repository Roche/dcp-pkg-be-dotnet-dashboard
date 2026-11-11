using System;
using System.ComponentModel.DataAnnotations;

namespace OpenDCP.Framework.Dashboard.Models
{
    public class DashboardTabDTO
    {
        public Guid Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        public int SiteId { get; set; }
        public bool IsGxp { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int? OwnerUserId { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
