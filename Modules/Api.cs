using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace NuistAutoLogin.Modules
{
    public enum Result
    {
        Success,
        WrongPassword,
        WrongUsername,
        IncompleteAccount,
        InternelError
    }
    public class Api
    {
        private States _state;
        private readonly RestClient _client;
        private readonly Logger _logger;
        public string Ip;

        private const string BaseUrl = "http://10.255.255.46/api/v1";

        public Api(States state, Logger logger)
        {
            _client = new RestClient(
                new RestClientOptions(BaseUrl)
                );
            _state = state;
            _logger = logger;
        }
        public async Task<string> GetIp()
        {
            var resp = await _client.GetJsonAsync<ResponseIP>("/ip");
            Logger.Log($"Get ip: {resp.data}");
            Ip = resp.data;
            return resp.data;
        }


        async public Task<Result> DoLogin()
        {
            var user = _state.user;
            var result = await _client.PostAsync<ResponseResult>(
              user.GenerateSecondAuth(Ip)
            );
            Logger.Log($"Login: {JsonConvert.SerializeObject(result)}");
            if (result.code == 200)
            {
                return Result.Success;
            }
            else if (result.code == 201)
            {
                if (result.data.text.Equals("Passwd_Err"))
                {
                    return Result.WrongPassword;
                }
                else if (result.data.text.Equals("UserName_Err"))
                {
                    return Result.WrongUsername;
                }
                else if (result.data.text.Contains("Account information is incomplete"))
                {
                    return Result.IncompleteAccount;
                }
            }
            return Result.InternelError;
        }
    }
}