using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Queries;
using GitLabApiClient.Models.Artifacts.Requests;

namespace GitLabApiClient
{
    public sealed class ArtifactsClient : IArtifactsClient
    {
        private readonly GitLabHttpFacade _httpFacade;
        private readonly ArtifactsQueryBuilder _queryBuilder;

        internal ArtifactsClient(GitLabHttpFacade httpFacade, ArtifactsQueryBuilder queryBuilder)
        {
            _httpFacade = httpFacade;
            _queryBuilder = queryBuilder;
        }

        public async Task<Stream> GetAsync(ProjectId projectId, int jobId, Action<ArtifactsQueryOptions> options = null)
        {
            var queryOptions = new ArtifactsQueryOptions();
            options?.Invoke(queryOptions);

            var url = _queryBuilder.Build($"projects/{projectId}/jobs/{jobId}/artifacts", queryOptions);
            return await _httpFacade.GetFile(url);
        }
    }
}
