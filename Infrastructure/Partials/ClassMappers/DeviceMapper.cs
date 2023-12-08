using DapperExtensions.Mapper;
using Infrastructure.DatabaseModels;

namespace Infrastructure.Partials.ClassMappers
{
    /// <summary>
    /// DeviceMapper class
    /// </summary>
    /// <seealso cref="ClassMapper&lt;Devices&gt;" />
    public class DeviceMapper : ClassMapper<Devices>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMapper"/> class.
        /// </summary>
        public DeviceMapper()
        {
            this.Table(nameof(Devices));
            this.AutoMap();
        }
    }
}
