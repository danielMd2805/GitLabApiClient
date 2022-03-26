using System;
using System.Collections.Generic;
using System.Text;
using GitLabApiClient.Models.Pipelines.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Job.Responses
{
    public class BridgeJob : Job
    {
        [JsonProperty("downstream_pipeline")]
        public Pipeline DownstreamPipeline { get; set; }
    }
}
