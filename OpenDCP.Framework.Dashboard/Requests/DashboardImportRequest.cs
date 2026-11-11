using OpenDCP.Framework.Configuration.Model.Entities.Site;
using System;

namespace OpenDCP.Framework.Dashboard.Requests
{
    public class DashboardImportRequest
    {
        public Guid OldDashboardTabId { get; set; }
        public Guid NewDashboardTabId { get; set; }
        public string ExportDate { get; set; }
        public LegacySiteConfigurationDTO_v2 SiteConfiguration { get; set; }
        public int CurrentUserId { get; set; }
        public bool IsGxp { get; set; }
    }
}
