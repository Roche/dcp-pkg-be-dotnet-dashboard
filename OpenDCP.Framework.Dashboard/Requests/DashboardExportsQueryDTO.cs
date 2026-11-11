using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Dashboard.Requests
{
    public class DashboardExportQueryDTO
    {
        public List<Guid> DashboardExportId { get; set; } = new List<Guid>();
        public List<int> SiteId { get; set; } = new List<int>();
    }
}
