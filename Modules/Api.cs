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
        private RestClient Client;
        public string IP;

        private readonly string baseUrl = "http://10.255.255.46/api/v1";

        public Api(States state)
        {
            Client = new RestClient(
                new RestClientOptions(baseUrl)
                );
            _state = state;
        }
        public async Task<string> GetIP()
        {
            var resp = await Client.GetJsonAsync<ResponseIP>("/ip");
            IP = resp.ip;
            return resp.ip;
        }


        async Task<Result> DoLogin()
        {
            var result = await Client.PostAsync(
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