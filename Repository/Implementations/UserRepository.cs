using System.Linq;
using DapperExtensions;
using Infrastructure.DatabaseModels;
using Microsoft.AspNetCore.Http;
using Repository.Interfaces;

namespace Repository.Implementations
{
    /// <summary>
    /// UserRepository class
    /// </summary>
    /// <seealso cref="BaseRepository{AspNetUsers}" />
    /// <seealso cref="IUserRepository" />
    public class UserRepository : BaseRepository<AspNetUsers>, IUserRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="httpContextAccessor">The HTTP context accessor.</param>
        public UserRepository(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        /// <summary>
        /// Gets the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <returns>
        /// the user object
        /// </returns>
        public AspNetUsers Get(string userId = null, string mobileNumber = null)
        {
            IPredicate predicate;
            if (!string.IsNullOrEmpty(userId))
            {
                predicate = Predicates.Field<AspNetUsers>(field => field.Id, Operator.Eq, userId);
            }
            else
            {
                predicate = Predicates.Field<AspNetUsers>(field => field.PhoneNumber, Operator.Eq, mobileNumber);
            }

            return UnitOfWork.Connection.GetList<AspNetUsers>(predicate).FirstOrDefault();
        }
    }
}