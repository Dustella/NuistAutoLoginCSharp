using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuistAutoLogin.Modules
{
    public class ResponseIP
    {
        public int code { get; set; }
        public string ip { get; set; }
    }

    public class UserRecord
    {
        public string username { get; set; }
        public string password { get; set; }
        public string carrier { get; set; }
    }

    class AuthRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public string ifautologin { get; set; }
        public string channel { get; set; }
        public string pagesign { get; set; }
        public string usripadd { get; set; }

    }
    public class RequestBody
    {
        private UserRecord _user;
        private string _ip;
        public RequestBody(UserRecord user, string ip)
        {
            _user = user;
            _ip = ip;
        }

        public RestRequest GenerateFirstAuth()
        => new RestRequest("/login").AddJsonBody(
               new AuthRequest
               {
                   channel = "0",
                   ifautologin = "0",
                   pagesign = "firstauth",
                   password = _user.password,
                   username = _user.username,
                   usripadd = _ip
               }
            );


        public RestRequest GenerateSecondAuth()
        => new RestRequest("/login").AddJsonBody(
            new AuthRequest
            {
                channel = "0",
                ifautologin = "0",
                pagesign = "secondauth",
                password = _user.password,
                username = _user.username,
                usripadd = _ip
            }
        );

    }
}