using System.Collections.Generic;

namespace AucklandTransportMetro.Http
{
    public class HttpResponse<TEntity> where TEntity : class
    {
        public List<TEntity> Response { get; set; }
        public string Status { get; set; }
    }
}