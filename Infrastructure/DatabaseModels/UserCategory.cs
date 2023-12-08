namespace Infrastructure.DatabaseModels
{
    /// <summary>
    /// UserCategory class
    /// </summary>
    /// <seealso cref="BaseDatabaseModel" />
    /// <seealso cref="IDatabaseEntity" />
    public partial class UserCategory : BaseDatabaseModel, IDatabaseEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        /// <value>
        /// The category identifier.
        /// </value>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the attribute key.
        /// </summary>
        /// <value>
        /// The attribute key.
        /// </value>
        public string AttributeKey { get; set; }

        /// <summary>
        /// Gets or sets the attribute value.
        /// </summary>
        /// <value>
        /// The attribute value.
        /// </value>
        public string AttributeValue { get; set; }
    }
}