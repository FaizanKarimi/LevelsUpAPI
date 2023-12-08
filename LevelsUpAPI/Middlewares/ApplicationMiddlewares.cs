using Infrastructure.Common;
using Microsoft.AspNetCore.Builder;

namespace LevelsUpAPI.Middlewares
{
    /// <summary>
    /// ApplicationMiddlewares class
    /// </summary>
    public static class ApplicationMiddlewares
    {
        /// <summary>
        /// Uses the levels up exception middleware.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns>
        /// the application builder
        /// </returns>
        public static IApplicationBuilder UseLevelsUpExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }

        /// <summary>
        /// Uses the levels up response request logging middleware.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns>
        /// the application builder
        /// </returns>
        public static IApplicationBuilder UseLevelsUpResponseRequestLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestResponseLoggingMiddleware>();
        }

        /// <summary>
        /// Uses the levels up authentication middleware.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns>
        /// the application builder
        /// </returns>
        public static IApplicationBuilder UseLevelsUpAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<JwtAuthenticationMiddleware>();
        }

        /// <summary>
        /// Uses the swagger.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns>
        /// the application builder
        /// </returns>
        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder builder)
        {
            builder.UseSwagger();
            return builder.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Test1 Api v1");
            });
        }
    }
}