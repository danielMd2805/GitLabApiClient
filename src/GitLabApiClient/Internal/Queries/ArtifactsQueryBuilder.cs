using GitLabApiClient.Models.Artifacts.Requests;

namespace GitLabApiClient.Internal.Queries
{
    internal class ArtifactsQueryBuilder : QueryBuilder<ArtifactsQueryOptions>
    {
        #region Overrides of QueryBuilder<PipelineQueryOptions>

        /// <inheritdoc />
        protected override void BuildCore(Query query, ArtifactsQueryOptions options)
        {
            if (!string.IsNullOrEmpty(options.JobToken))
            {
                query.Add("job_token", options.JobToken);
            }
        }

        #endregion
    }
}
