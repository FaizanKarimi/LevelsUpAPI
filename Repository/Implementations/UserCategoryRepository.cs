using System.Collections.Generic;
using System.Linq;
using DapperExtensions;
using Infrastructure.DatabaseModels;
using Microsoft.AspNetCore.Http;
using Repository.Interfaces;

namespace Repository.Implementations
{
    /// <summary>
    /// UserCategoryRepository class
    /// </summary>
    /// <seealso cref="BaseRepository{UserCategory}" />
    /// <seealso cref="IUserCategoryRepository" />
    public class UserCategoryRepository : BaseRepository<UserCategory>, IUserCategoryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCategoryRepository"/> class.
        /// </summary>
        /// <param name="httpContextAccessor">The HTTP context accessor.</param>
        public UserCategoryRepository(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        /// <summary>
        /// Gets the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>
        /// list of user categories
        /// </returns>
        public List<UserCategory> Get(string userId)
        {
            IPredicate predicate = Predicates.Field<UserCategory>(field => field.UserId, Operator.Eq, userId);
            return UnitOfWork.Connection.GetList<UserCategory>(predicate).ToList();
        }
    }
}