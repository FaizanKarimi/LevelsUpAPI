using Infrastructure.DatabaseModels;
using Microsoft.AspNetCore.Http;
using Repository.Interfaces;

namespace Repository.Implementations
{
    /// <summary>
    /// CategoryRepository class
    /// </summary>
    /// <seealso cref="BaseRepository{Category}" />
    /// <seealso cref="ICategoryRepository" />
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRepository"/> class.
        /// </summary>
        /// <param name="httpContextAccessor">The HTTP context accessor.</param>
        public CategoryRepository(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}