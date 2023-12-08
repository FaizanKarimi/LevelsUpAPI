namespace Infrastructure.DatabaseModels
{
    /// <summary>
    /// SubCategory class
    /// </summary>
    /// <seealso cref="BaseDatabaseModel" />
    /// <seealso cref="IDatabaseEntity" />
    public partial class SubCategory : BaseDatabaseModel, IDatabaseEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        /// <value>
        /// The category identifier.
        /// </value>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        /// <value>
        /// The image path.
        /// </value>
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is locked.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is locked; otherwise, <c>false</c>.
        /// </value>
        public bool IsLocked { get; set; }

        /// <summary>
        /// Gets or sets the plays per day.
        /// </summary>
        /// <value>
        /// The plays per day.
        /// </value>
        public int PlaysPerDay { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the repetitions.
        /// </summary>
        /// <value>
        /// The repetitions.
        /// </value>
        public int Repetitions { get; set; }

        /// <summary>
        /// Gets or sets the total points.
        /// </summary>
        /// <value>
        /// The total points.
        /// </value>
        public int TotalPoints { get; set; }
    }
}