namespace Identity.Models
{
    /// <summary>
    /// UserSubCategory class
    /// </summary>
    /// <seealso cref="BaseModel" />
    public class UserSubCategory : BaseModel
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
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public virtual LevelsUpUser User { get; set; }

        /// <summary>
        /// Gets or sets the sub category identifier.
        /// </summary>
        /// <value>
        /// The sub category identifier.
        /// </value>
        public int SubCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the sub category.
        /// </summary>
        /// <value>
        /// The sub category.
        /// </value>
        public virtual UserCategory SubCategory { get; set; }

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

        /// <summary>
        /// Gets or sets the repetitions.
        /// </summary>
        /// <value>
        /// The repetitions.
        /// </value>
        public int Repetitions { get; set; }
    }
}