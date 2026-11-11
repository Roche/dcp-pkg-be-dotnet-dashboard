using System;

namespace OpenDCP.Framework.Dashboard.Models
{
    /// <summary>
    /// Data transfer object representing the layout specifics for an individual dashboard item.
    /// Used to define how a single component is positioned and sized within the parent grid.
    /// </summary>
    public class DashboardTabLayoutDetailsDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier for the specific dashboard item being positioned.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the grid-based layout settings, such as column and row, 
        /// for this specific dashboard item.
        /// </summary>
        public DashboardLayout GridLayout { get; set; } = new DashboardLayout();
    }
}
