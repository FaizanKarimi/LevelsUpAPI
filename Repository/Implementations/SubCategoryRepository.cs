﻿using System.Collections.Generic;
using System.Linq;
using DapperExtensions;
using Infrastructure.DatabaseModels;
using Microsoft.AspNetCore.Http;
using Repository.Interfaces;

namespace Repository.Implementations
{
    /// <summary>
    /// SubCategoryRepository class
    /// </summary>
    /// <seealso cref="ISubCategoryRepository" />
    public class SubCategoryRepository : BaseRepository<SubCategory>, ISubCategoryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubCategoryRepository"/> class.
        /// </summary>
        /// <param name="httpContextAccessor">The HTTP context accessor.</param>
        public SubCategoryRepository(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        /// <summary>
        /// Gets the sub categories.
        /// </summary>
        /// <param name="categoryId">The category identifier.</param>
        /// <returns>
        /// the list of sub categories
        /// </returns>
        public List<SubCategory> GetSubCategories(int categoryId)
        {
            IPredicate predicate = Predicates.Field<SubCategory>(field => field.CategoryId, Operator.Eq, categoryId);
            return UnitOfWork.Connection.GetList<SubCategory>(predicate).ToList();
        }
    }
}