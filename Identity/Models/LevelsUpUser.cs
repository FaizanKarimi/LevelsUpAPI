using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Identity.Models
{
    /// <summary>
    /// LevelsUpUser class
    /// </summary>
    /// <seealso cref="IdentityUser" />
    public class LevelsUpUser : IdentityUser
    {
        /// <summary>
        /// Gets or sets the date registration.
        /// </summary>
        /// <value>
        /// The date registration.
        /// </value>
        public DateTime DateRegistration { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        public ICollection<Category> Categories { get; set; }

        #region Devices Navigation Properties
        /// <summary>
        /// Gets or sets the device.
        /// </summary>
        /// <value>
        /// The device.
        /// </value>
        public virtual ICollection<Devices> Device { get; set; }

        /// <summary>
        /// Gets or sets the devices.
        /// </summary>
        /// <value>
        /// The devices.
        /// </value>
        public virtual ICollection<Devices> Devices { get; set; }
        #endregion

        #region RefreshToken Navigation Properties
        /// <summary>
        /// Gets or sets the refresh tokens.
        /// </summary>
        /// <value>
        /// The refresh tokens.
        /// </value>
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        /// <value>
        /// The refresh token.
        /// </value>
        public virtual ICollection<RefreshToken> RefreshToken { get; set; } 
        #endregion

        /// <summary>
        /// Gets or sets the sub categories.
        /// </summary>
        /// <value>
        /// The sub categories.
        /// </value>
        public virtual ICollection<SubCategory> SubCategories { get; set; }

        #region UserProfiles Navigation Properties
        /// <summary>
        /// Gets or sets the user profile.
        /// </summary>
        /// <value>
        /// The user profile.
        /// </value>
        public virtual UserProfile UserProfiles { get; set; }

        /// <summary>
        /// Gets or sets the user profile.
        /// </summary>
        /// <value>
        /// The user profile.
        /// </value>
        public virtual UserProfile UserProfile { get; set; } 
        #endregion

        #region UserCategories Navigation Properties
        /// <summary>
        /// Gets or sets the user categories.
        /// </summary>
        /// <value>
        /// The user categories.
        /// </value>
        public virtual ICollection<UserCategory> UserCategories { get; set; }

        /// <summary>
        /// Gets or sets the user category.
        /// </summary>
        /// <value>
        /// The user category.
        /// </value>
        public virtual ICollection<UserCategory> UserCategory { get; set; } 
        #endregion

        /// <summary>
        /// Gets or sets the user sub categories.
        /// </summary>
        /// <value>
        /// The user sub categories.
        /// </value>
        public ICollection<UserSubCategory> UserSubCategories { get; set; }
    }
}