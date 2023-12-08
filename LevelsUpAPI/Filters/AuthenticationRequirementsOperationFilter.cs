using System.Collections.Generic;
using Infrastructure.Common;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LevelsUpAPI.Filters
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IOperationFilter" />
    public class AuthenticationRequirementsOperationFilter : IOperationFilter
    {
        /// <summary>
        /// Applies the specified operation.
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <param name="context">The context.</param>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Security == null)
            {
                operation.Security = new List<OpenApiSecurityRequirement>();
            }


            OpenApiSecurityScheme scheme = new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = Constants.TokenType
                }
            };
            operation.Security.Add(new OpenApiSecurityRequirement
            {
                [scheme] = new List<string>()
            });
        }
    }
}