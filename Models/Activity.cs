using System.Text.Json.Serialization;

namespace GitHubUserActivity.Models
{
    public class Activity
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("actor")]
        public Actor? Actor { get; set; }

        [JsonPropertyName("repo")]
        public Repository? Repo { get; set; }
    }
}
