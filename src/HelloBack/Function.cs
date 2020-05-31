using Amazon.Lambda.Core;
using System;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloBack
{
    public class Function
    {
        public string FunctionHandler()
        {
            return "hello world";
        }
    }

  

    public class WorldHello
    {
        public string GithubUserName { get; set;}
        public string TwitterUserName { get; set;}
        public string GithubProfilePictureUrl { get; set;}
        public string RepositoryName { get; set;}
        public string RepositoryUrl { get; set;}
        public string CommitMessage { get; set;}
        public DateTime CommitTime { get; set;}
    }
}
