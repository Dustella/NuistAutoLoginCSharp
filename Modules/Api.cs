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
    internal class Api

    {
        private string Username;
        private string Password;
        private string Carrier;
        private RestClient Client;
        public string IP;

        private readonly string baseUrl = "http://10.255.255.46/api/v1";

        Api(string username, string password, string carrier)
        {
            Client = new RestClient(
                new RestClientOptions(baseUrl)
                );
            Username = username;
            Password = password;
            Carrier = carrier;
        }
        async Task<string> GetIP()
        {
            var resp = await Client.GetJsonAsync<ResponseIP>(
                "/ip"
                );
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