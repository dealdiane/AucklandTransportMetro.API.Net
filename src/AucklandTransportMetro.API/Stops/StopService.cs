using AucklandTransportMetro.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace AucklandTransportMetro.Stops
{
    public class StopService : HttpService
    {
        private static readonly Uri _stopBaseUri = new Uri("https://api.at.govt.nz/v2/gtfs/stops", UriKind.Absolute);

        public StopService(Uri baseUri) : base(baseUri)
        {
        }

        public StopService()
            : this(_stopBaseUri)
        {
        }

        public IAsyncEnumerable<Stop> GetAllStopsAsync()
        {
            return Observable.Create<Stop>(
                async (observer, cancellationToken) =>
                {
                    var stops = await GetAsync<Stop>(new Uri("/"));

                    foreach (var stop in stops)
                    {
                        observer.OnNext(stop);
                    }
                })
                .ToAsyncEnumerable();
        }
    }
}