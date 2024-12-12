using System.Text.Json.Serialization;

namespace GitHubUserActivity.Models
{
    public class Actor
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("login")]
        public string Login { get; set; } = string.Empty;
    }
}
