using OpenDCP.Framework.Dashboard.Constants;
using System;

namespace OpenDCP.Framework.Dashboard.Models
{
    public class DashboardItemLayout<T> where T : DashboardItemLayoutData
    {
        public Guid Id { get; set; }
        public string TabName { get; set; }
        public DashboardType Type { get; set; }
        public string Tag { get; set; }
        public DashboardLayout GridLayout { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsValidated { get; set; }
        public T Configuration { get; set; }
        public string ModuleShort { get; set; }
        public int SiteId { get; set; }
    }
}
