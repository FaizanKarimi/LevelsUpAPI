using DapperExtensions.Mapper;
using Infrastructure.DatabaseModels;

namespace Infrastructure.Partials.ClassMappers
{
    /// <summary>
    /// UserProfileMapper class
    /// </summary>
    /// <seealso cref="ClassMapper{UserProfile}" />
    public class UserProfileMapper : ClassMapper<UserProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileMapper"/> class.
        /// </summary>
        public UserProfileMapper()
        {
            this.Table(nameof(UserProfile));
            this.Map(x => x.User).Ignore();
            this.AutoMap();
        }
    }
}