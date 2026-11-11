using OpenDCP.Framework.Dashboard.Models;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Dashboard.Requests
{
    /// <summary>
    /// Data transfer object used for request purposes to configure or update the spatial layout of a dashboard tab.
    /// Defines the positioning and sizing for a collection of dashboard items.
    /// </summary>
    public class DashboardTabLayoutConfigurationDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the dashboard tab for which the layout is being configured.
        /// </summary>
        public Guid DashboardTabId { get; set; }

        /// <summary>
        /// Gets or sets the list of layout details, specifying the grid positions
        /// for each item in the request.
        /// </summary>
        public List<DashboardTabLayoutDetailsDTO> DashboardTabLayoutDetails { get; set; } = new List<DashboardTabLayoutDetailsDTO>();

        /// <summary>
        /// Gets or sets the identifier of the user submitting the layout configuration.
        /// </summary>
        public int UserId { get; set; }
    }
}
