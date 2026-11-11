using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Dashboard.Models
{
    /// <summary>
    /// Data transfer object representing the overall layout configuration for a dashboard tab.
    /// Used to synchronize the positions and dimensions of multiple dashboard items.
    /// </summary>
    public class DashboardTabLayoutDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the dashboard tab to which this layout applies.
        /// </summary>
        public Guid DashboardTabId { get; set; }

        /// <summary>
        /// Gets or sets the detailed positioning information for each item within the layout.
        /// </summary>
        public List<DashboardTabLayoutDetailsDTO> DashboardTabLayoutDetails { get; set; } = new List<DashboardTabLayoutDetailsDTO>();

        /// <summary>
        /// Gets or sets the identifier for the site associated with this layout.
        /// </summary>
        public int SiteId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who owns or defined this specific layout.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this layout configuration is subject to GxP (Good Practice) compliance.
        /// </summary>
        public bool IsGxp { get; set; }
    }
}
