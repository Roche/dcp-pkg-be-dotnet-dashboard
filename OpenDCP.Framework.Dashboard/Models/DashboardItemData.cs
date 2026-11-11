using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Dashboard.Models
{
    public class DashboardItemData : DashboardItemDataCommon
    {
        public Guid DashboardId { get; set; }
        public List<DashboardItemDataCommon> Items { get; set; }
    }
}
