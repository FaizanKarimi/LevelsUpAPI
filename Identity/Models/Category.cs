using System.Collections.Generic;

namespace Identity.Models
{
    /// <summary>
    /// Category class
    /// </summary>
    /// <seealso cref="BaseModel" />
    public class Category : BaseModel
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

        /// <summary>
        /// Gets or sets the sub categories.
        /// </summary>
        /// <value>
        /// The sub categories.
        /// </value>
        public virtual ICollection<SubCategory> SubCategories { get; set; }

        /// <summary>
        /// Gets or sets the user categories.
        /// </summary>
        /// <value>
        /// The user categories.
        /// </value>
        public virtual ICollection<UserCategory> UserCategories { get; set; }
    }
}