namespace todo.Models
{
    using Microsoft.Azure.Documents;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class User
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "bands")]
        public ICollection<string> Bands { get; set; }

        [JsonProperty(PropertyName = "events")]
        public ICollection<string> Events { get; set; }
    }
}