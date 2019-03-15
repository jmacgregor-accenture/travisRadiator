using System;
using RestSharp;
using static TravisRadiator.ApiService.Secret;

namespace TravisRadiator.ApiService
{
    public class TravisApiExperiment
    {
        RestClient _client = new RestClient("https://api.travis-ci.org");
        
        public string GetOwner(string userId)
        {
            
            
            var request = new RestRequest($"/owner/{userId}", Method.GET);
            request.AddHeader("Travis-API-Version", "3");
            request.AddHeader("User-Agent", "JDM-DotNet");
            request.AddHeader("Authorization",$"token {TRAVIS_TOKEN}");

            var response = _client.Execute(request);

            return response.Content;
        }

        public string GetUser()
        {
            var request = new RestRequest($"/user", Method.GET);
            request.AddHeader("Travis-API-Version", "3");
            request.AddHeader("User-Agent", "JDM-DotNet");
            request.AddHeader("Authorization",$"token {TRAVIS_TOKEN}");

            var response = _client.Execute(request);

            return response.Content;
        }
    }
}