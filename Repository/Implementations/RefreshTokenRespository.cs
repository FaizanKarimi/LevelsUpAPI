﻿using System.Collections.Generic;
using System.Linq;
using DapperExtensions;
using Infrastructure.DatabaseModels;
using Microsoft.AspNetCore.Http;
using Repository.Interfaces;

namespace Repository.Implementations
{
    /// <summary>
    /// RefreshTokenRespository class
    /// </summary>
    /// <seealso cref="BaseRepository{RefreshToken}" />
    /// <seealso cref="IRefreshTokenRespository" />
    public class RefreshTokenRespository : BaseRepository<RefreshToken>, IRefreshTokenRespository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenRespository"/> class.
        /// </summary>
        /// <param name="httpContextAccessor">The HTTP context accessor.</param>
        public RefreshTokenRespository(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        /// <summary>
        /// Gets the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="refreshToken">The refresh token.</param>
        /// <returns>
        /// the refresh token object
        /// </returns>
        public RefreshToken Get(string userId, string refreshToken)
        {
            IPredicateGroup predicateGroup = new PredicateGroup() { Operator = GroupOperator.And, Predicates = new List<IPredicate>() };
            predicateGroup.Predicates.Add(Predicates.Field<RefreshToken>(field => field.UserId, Operator.Eq, userId));
            predicateGroup.Predicates.Add(Predicates.Field<RefreshToken>(field => field.Token, Operator.Eq, refreshToken));
            return UnitOfWork.Connection.GetList<RefreshToken>(predicateGroup).FirstOrDefault();
        }
    }
}
