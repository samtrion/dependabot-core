namespace NuGetUpdater.Core.Run.ApiModel;

public record JobRepoNotFound : JobErrorBase
{
    public JobRepoNotFound(string message)
        : base("job_repo_not_found")
    {
        Details = new Dictionary<string, string>()
        {
            ["message"] = message
        };
    }
}