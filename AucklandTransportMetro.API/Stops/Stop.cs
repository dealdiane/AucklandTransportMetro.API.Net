using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AucklandTransportMetro.Stops
{
    public class Stop
    {
        [JsonProperty(PropertyName = "stop_city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "stop_code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "stop_country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "stop_desc")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "direction")]
        public int? Direction { get; set; }

        [JsonProperty(PropertyName = "wheelchair_boarding")]
        public bool? HasWheelchairBoarding { get; set; }

        [JsonProperty(PropertyName = "stop_id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "stop_lat")]
        public double Latitude { get; set; }

        [JsonProperty(PropertyName = "location_type")]
        public int LocationType { get; set; }

        [JsonProperty(PropertyName = "stop_lon")]
        public double Longitude { get; set; }

        [JsonProperty(PropertyName = "stop_name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "parent_station")]
        public int? ParentStation { get; set; }

        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

        [JsonProperty(PropertyName = "stop_postcode")]
        public string PostCode { get; set; }

        [JsonProperty(PropertyName = "stop_region")]
        public string Region { get; set; }

        [JsonProperty(PropertyName = "stop_street")]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "the_geom")]
        public string TheGeom { get; set; }

        [JsonProperty(PropertyName = "stop_timezone")]
        public string TimeZone { get; set; }

        [JsonProperty(PropertyName = "stop_url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "zone_id")]
        public int? ZoneId { get; set; }
    }
}
