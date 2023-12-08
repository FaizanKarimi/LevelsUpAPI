using System;

namespace Infrastructure.DatabaseModels
{
    /// <summary>
    /// BaseDatabaseModel class
    /// </summary>
    public class BaseDatabaseModel
    {
        /// <summary>
        /// Gets or sets the created by identifier.
        /// </summary>
        /// <value>
        /// The created by identifier.
        /// </value>
        public string CreatedById { get; set; }

        /// <summary>
        /// Gets or sets the created on.
        /// </summary>
        /// <value>
        /// The created on.
        /// </value>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the updated by identifier.
        /// </summary>
        /// <value>
        /// The updated by identifier.
        /// </value>
        public string UpdatedById { get; set; }

        /// <summary>
        /// Gets or sets the updated on.
        /// </summary>
        /// <value>
        /// The updated on.
        /// </value>
        public DateTime? UpdatedOn { get; set; }
    }
}