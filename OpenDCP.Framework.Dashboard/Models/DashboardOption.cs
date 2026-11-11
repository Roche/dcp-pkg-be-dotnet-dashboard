using System.Collections.Generic;

namespace OpenDCP.Framework.Dashboard.Models
{
    public class DashboardOption
    {
        /// <summary>
        /// The list of permission identifiers required for this dashboard option to be available or visible to a user.
        /// </summary>
        public List<string> Permissions { get; set; }

        /// <summary>
        /// The display label shown to the user for this dashboard option.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The URL associated with this dashboard option.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// A value indicating whether actions related to this dashboard option should be recorded for auditing purposes.
        /// </summary>
        public bool IsAuditable { get; set; }
    }
}
