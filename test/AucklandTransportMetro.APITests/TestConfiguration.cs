using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace AucklandTransportMetro.APITests
{
    public static class TestConfiguration
    {
        static TestConfiguration()
        {
            var environmentName = Environment.GetEnvironmentVariable("Hosting:Environment");

            var builder = new ConfigurationBuilder()
                .SetBasePath(System.AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{Environment.MachineName.ToLowerInvariant()}.json", true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public static IConfiguration Configuration { get; private set; }
    }
}