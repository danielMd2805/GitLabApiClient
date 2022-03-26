using System;
using System.IO;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Models.Artifacts.Requests;

namespace GitLabApiClient
{
    public interface IArtifactsClient
    {
        Task<Stream> GetAsync(ProjectId projectId, int jobId, Action<ArtifactsQueryOptions> options = null);
    }
}
