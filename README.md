# GitHubUserActivity

GitHubUserActivity URL : https://roadmap.sh/projects/github-user-activity

.NET 8 Console app solution for the github-user-activity [challenge](https://roadmap.sh/projects/github-user-activity) from [roadmap.sh](https://roadmap.sh/).

GitHub Activity CLI is a command-line interface (CLI) application built in C# that fetches and displays the recent activity of a specified GitHub user. This project helps you practice working with APIs, handling JSON data, and building a simple CLI application.

## Features 
- **Fetch Recent Activity**: Retrieve recent GitHub activities of a specified user.
- **Display Activities**: Show the activities in a user-friendly format in the terminal.
- **Error Handling**: Gracefully handle errors such as invalid usernames or API failures.

## Getting Started 

### Prerequisites 

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 8.0 or later)

### Installation 1. 

1. **Clone the Repository**: 
    ```sh 
    git clone https://github.com/AndyHanzawa/GitHubUserActivity
    ```
    ```sh
    cd GitHubUserActivity
    ``` 
2. **Build the Project**:
    ```sh
    dotnet build
    ```
### Usage Run the application from the command line by providing a GitHub username as an argument:
    dotnet run <username>

### Example
    dotnet run AndyHanzawa

### Output
    Created 2 branch(s) or tag(s) in repository AndyHanzawa/GitHubUserActivity
    Pushed 6 commit(s) in repository AndyHanzawa/TaskTracker
    Created 2 branch(s) or tag(s) in repository AndyHanzawa/TaskTracker
    Created 9 branch(s) or tag(s) in repository AndyHanzawa/TaskTrackerCLI
    Pushed 1 commit(s) in repository AndyHanzawa/TaskTrackerCLI
    DeleteEvent: 2 in repository AndyHanzawa/TaskTrackerCLI

## Contact

If you have any questions or suggestions, feel free to open an issue or reach out directly.

---

Happy coding! 😊
