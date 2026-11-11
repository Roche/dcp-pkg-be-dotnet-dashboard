using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Dashboard.Requests
{
    public class DashboardTabQueryDTO
    {
        public List<Guid> DashboardTabId { get; set; } = new List<Guid>();
        public List<int> SiteId { get; set; } = new List<int>();
    }
}
