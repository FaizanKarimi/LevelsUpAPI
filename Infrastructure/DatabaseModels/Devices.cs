namespace Infrastructure.DatabaseModels
{
    /// <summary>
    /// Devices class
    /// </summary>
    /// <seealso cref="BaseDatabaseModel" />
    /// <seealso cref="IDatabaseEntity" />
    public class Devices : BaseDatabaseModel, IDatabaseEntity
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
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>
        /// The mobile number.
        /// </value>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets the device token.
        /// </summary>
        /// <value>
        /// The device token.
        /// </value>
        public string DeviceToken { get; set; }

        /// <summary>
        /// Gets or sets the registration token.
        /// </summary>
        /// <value>
        /// The registration token.
        /// </value>
        public string RegistrationToken { get; set; }

        /// <summary>
        /// Gets or sets the device type identifier.
        /// </summary>
        /// <value>
        /// The device type identifier.
        /// </value>
        public int? DeviceTypeId { get; set; }
    }
}