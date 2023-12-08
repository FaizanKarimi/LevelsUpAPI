using DapperExtensions.Mapper;
using Infrastructure.DatabaseModels;

namespace Infrastructure.Partials.ClassMappers
{
    /// <summary>
    /// UserSubCategoryMapper class
    /// </summary>
    /// <seealso cref="ClassMapper{UserCategory}" />
    public class UserSubCategoryMapper : ClassMapper<UserSubCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubCategoryMapper"/> class.
        /// </summary>
        public UserSubCategoryMapper()
        {
            this.Table(nameof(UserSubCategory));
            this.Map(x => x.SubCategory).Ignore();
            this.Map(x => x.User).Ignore();
            this.AutoMap();
        }
    }
}