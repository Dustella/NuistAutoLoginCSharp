using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace NuistAutoLogin.Modules
{
    public enum Result
    {
        Success,
        WrongPassword,
        WrongUsername,
        InternelError
    }
    public class Api
    {
        private States _state;
        private readonly RestClient _client;
        public string Ip;

        private const string BaseUrl = "http://10.255.255.46/api/v1";

        public Api(States state, Logger logger)
        {
            _client = new RestClient(
                new RestClientOptions(BaseUrl)
                );
            _state = state;
        }
        public async Task<string> GetIp()
        {
            var resp = await _client.GetJsonAsync<ResponseIP>("/ip");
            Ip = resp.ip;
            return resp.ip;
        }


        async Task<Result> DoLogin()
        {
            var result = await _client.PostAsync(
              new RestRequest("/login").AddJsonBody(
                  new { id = 1 })
               );

            if (result.IsSuccessStatusCode == true)
            {
                return Result.Success;
            }
            return Result.InternelError;
        }
    }
}