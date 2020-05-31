using System;

using Dapr.Actors.AspNetCore;

using ExtenFlow.EventStorage;
using ExtenFlow.EventStorage.InMemory;
using ExtenFlow.Identity.Roles.Helpers;
using ExtenFlow.Identity.Roles.Queries;
using ExtenFlow.Messages.Events;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ExtenFlow.Identity.StoreActors
{
    /// <summary>
    /// The program class
    /// </summary>
    public static class Program
    {
        private const int _appChannelHttpPort = 3000;

        /// <summary>
        /// Creates a IWebHostBuilder.
        /// </summary>
        /// <param name="args">Arguments.</param>
        /// <returns>IWebHostBuilder instance.</returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            string? aspnetcoreEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            IConfigurationRoot currentConfig = new ConfigurationBuilder()
                    .AddJsonFile($"appsettings.json")
                    .AddJsonFile($"appsettings.{aspnetcoreEnvironment}.json")
                    .Build();

            return WebHost
                .CreateDefaultBuilder(args)
                    .UseConfiguration(currentConfig)
                    .UseStartup<Startup>()
                    .UseActors(actorRuntime =>
                    {
                        IEventPublisher eventPublisher = new InMemoryEventBus();
                        IEventStore eventStore = new EventStore();
                        actorRuntime.RegisterIdentityRoleActors(eventPublisher, eventStore);
                        //actorRuntime.RegisterUserActors();
                    })
                    .UseUrls($"http://localhost:{_appChannelHttpPort}/");
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args) => CreateWebHostBuilder(args).Build().Run();
    }
}