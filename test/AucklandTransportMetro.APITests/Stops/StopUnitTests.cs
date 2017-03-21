using AucklandTransportMetro.Stops;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AucklandTransportMetro.APITests
{
    public class StopUnitTests
    {
        private readonly ApiSettings _settings;

        public StopUnitTests()
        {
            TestConfiguration.Configuration.GetSection("Settings").Bind(_settings = new ApiSettings());
        }

        [Fact]
        public async Task Can_get_all_stops()
        {
            var stops = await CreateService().GetAllStopsAsync().ToList();

            Assert.NotEmpty(stops);
        }

        private StopService CreateService()
        {
            return new StopService
            {
                SubscriptionKey = _settings.ApiKey,
            };
        }
    }
}