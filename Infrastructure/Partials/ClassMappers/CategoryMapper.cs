using DapperExtensions.Mapper;
using Infrastructure.DatabaseModels;

namespace Infrastructure.Partials.ClassMappers
{
    /// <summary>
    /// CategoryMapper class
    /// </summary>
    /// <seealso cref="ClassMapper{Category}" />
    public class CategoryMapper : ClassMapper<Category>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryMapper"/> class.
        /// </summary>
        public CategoryMapper()
        {
            this.Table(nameof(Category));
            this.Map(m => m.UserCategories).Ignore();
            this.AutoMap();
        }
    }
}