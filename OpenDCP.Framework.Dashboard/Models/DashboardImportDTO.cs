using System;
using System.ComponentModel.DataAnnotations;

namespace OpenDCP.Framework.Dashboard.Models
{
    public class DashboardImportDTO
    {
        public Guid DashboardImportGUID { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        public int SiteId { get; set; }
    }
}
