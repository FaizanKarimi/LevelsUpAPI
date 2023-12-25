using System;
using System.Threading;
using System.Threading.Tasks;
using Logging;
using Microsoft.Extensions.Hosting;

namespace LevelsUpAPI.BackgroundServices
{
    /// <summary>
    /// DeleteRevokedRefreshTokens class
    /// </summary>
    /// <seealso cref="BackgroundService" />
    public class DeleteRevokedRefreshTokens : BackgroundService
    {
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRevokedRefreshTokens"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public DeleteRevokedRefreshTokens(ILogger logger)
        {
            this._logger = logger;
        }

        /// <summary>
        /// This method is called when the <see cref="T:Microsoft.Extensions.Hosting.IHostedService" /> starts. The implementation should return a task that represents
        /// the lifetime of the long running operation(s) being performed.
        /// </summary>
        /// <param name="stoppingToken">Triggered when <see cref="M:Microsoft.Extensions.Hosting.IHostedService.StopAsync(System.Threading.CancellationToken)" /> is called.</param>
        /// <returns>
        /// A <see cref="T:System.Threading.Tasks.Task" /> that represents the long running operations.
        /// </returns>
        /// <remarks>
        /// See <see href="https://docs.microsoft.com/dotnet/core/extensions/workers">Worker Services in .NET</see> for implementation guidelines.
        /// </remarks>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            this._logger.Debug($"Service started at: {DateTimeOffset.Now}");

            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    this._logger.Debug($"Deleting the revoked refresh tokens: {DateTimeOffset.Now}");
                    await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this._logger.Debug($"Service stopped at: {DateTimeOffset.Now}");
            }
        }
    }
}