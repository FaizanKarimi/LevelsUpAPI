using DapperExtensions.Mapper;

namespace Infrastructure.Partials.ClassMappers
{
    /// <summary>
    /// RefreshTokenMapper class
    /// </summary>
    /// <seealso cref="ClassMapper&lt;RefreshToken&gt;" />
    public class RefreshTokenMapper : ClassMapper<RefreshToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenMapper"/> class.
        /// </summary>
        public RefreshTokenMapper()
        {
            this.Table(nameof(RefreshToken));
            this.AutoMap();
        }
    }
}