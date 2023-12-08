namespace Infrastructure.DatabaseModels
{
    /// <summary>
    /// Category class
    /// </summary>
    /// <seealso cref="BaseDatabaseModel" />
    /// <seealso cref="IDatabaseEntity" />
    public partial class Category : BaseDatabaseModel, IDatabaseEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is locked.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is locked; otherwise, <c>false</c>.
        /// </value>
        public bool IsLocked { get; set; }
    }
}