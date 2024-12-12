using GitHubUserActivity.Models;
using System.Text.Json;
using System.Web;

namespace GitHubUserActivity
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a username.");
                return;
            }

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");

            var activities = await GetUserActivities(client, args[0]);

            var repositories = activities.GroupBy(t => t.Repo.Name);

            foreach (var repo in repositories)
            {
                var activitiesInRepo = repo.GroupBy(t => t.Type);
                foreach (var activity in activitiesInRepo)
                {
                    switch (activity.Key)
                    {
                        case "CreateEvent":
                            Console.WriteLine($"Created {activity.LongCount()} branch(s) or tag(s) in repository {repo.Key}");
                            break;
                        case "PushEvent":
                            Console.WriteLine($"Pushed {activity.LongCount()} commit(s) in repository {repo.Key}");
                            break;

                        case "PullRequestEvent":
                            Console.WriteLine($"Opened {activity.LongCount()} pull(s) request(s) in repository {repo.Key}");
                            break;

                        case "IssueCommentEvent":
                            Console.WriteLine($"Added {activity.LongCount()} comment(s) in repository {repo.Key}");
                            break;

                        case "IssuesEvent":
                            Console.WriteLine($"Opened {activity.LongCount()} issue(s) in repository {repo.Key}");
                            break;

                        case "WatchEvent":
                            Console.WriteLine($"Starred {activity.LongCount()} repository {repo.Key}");
                            break;

                        default:
                            Console.WriteLine($"{activity.Key}: {activity.LongCount()} in repository {repo.Key}");
                            break;

                    }
                }
            }

        }
        static async Task<List<Activity>> GetUserActivities(HttpClient client, string username)
        {
            try
            {
                var encodedUsername = HttpUtility.UrlEncode(username);

                var url = $"https://api.github.com/users/{encodedUsername}/events";
                var httpResponse = await client.GetAsync(url);
                httpResponse.EnsureSuccessStatusCode();

                var content = await httpResponse.Content.ReadAsStringAsync();
                var activities = JsonSerializer.Deserialize<List<Activity>>(content);

                return activities ?? new();
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is problem in fetching your git hub activities.");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}