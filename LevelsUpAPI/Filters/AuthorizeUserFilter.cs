using System.Linq;
using System.Security.Claims;
using Infrastructure.Enums;
using Infrastructure.Exceptions;
using Infrastructure.ExtensionMethods.Framework;
using Infrastructure.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LevelsUpAPI.Filters
{
    /// <summary>
    /// AuthorizeUserFilter class
    /// </summary>
    /// <seealso cref="IAuthorizationFilter" />
    public class AuthorizeUserFilter : IAuthorizationFilter
    {
        public bool _isAll { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeUserFilter"/> class.
        /// </summary>
        /// <param name="IsAll">if set to <c>true</c> [is all].</param>
        public AuthorizeUserFilter(bool IsAll)
        {
            this._isAll = IsAll;
        }

        /// <summary>
        /// Called early in the filter pipeline to confirm request is authorized.
        /// </summary>
        /// <param name="context">The <see cref="T:Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext" />.</param>
        /// <exception cref="LevelsUpException">Authorization error</exception>
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            HttpContext httpContext = context.HttpContext;

            if (context.Filters.Any(filter => filter is IAllowAnonymous))
            {
                return;
            }

            if (httpContext.User.Identity.IsAuthenticated == false)
            {
                throw new LevelsUpException(ErrorMessages.UNAUTHORIZED_ERROR, ErrorCodes.Unauthorized);
            }

            if (httpContext.User.HasClaim(x => x.Type == ClaimTypes.Role) == false)
            {
                throw new LevelsUpException(ErrorMessages.UNAUTHORIZED_ERROR, ErrorCodes.Unauthorized);
            }

            UserRoles role = EnumHelpers.ToEnum<UserRoles>(httpContext.User.Claims.GetClaimValue(ClaimTypes.Role));
            if (!this._isAll && role != UserRoles.User)
            {
                throw new LevelsUpException(ErrorMessages.UNAUTHORIZED_ERROR, ErrorCodes.Unauthorized);
            }
        }
    }
}