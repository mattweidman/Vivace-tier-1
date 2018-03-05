namespace vivace.Models
{
    using Microsoft.Azure.Documents;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Band
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "users")]
        public IEnumerable<string> Users { get; set; }

        [JsonProperty(PropertyName = "songs")]
        public IEnumerable<string> Songs { get; set; }

        [JsonProperty(PropertyName = "events")]
        public IEnumerable<string> Events { get; set; }
    }
}