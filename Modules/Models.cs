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
        public string data { get; set; }
    }

    public class UserRecord
    {
        public string username { get; set; }
        public string password { get; set; }
        public string carrier { get; set; }


        private string getChannel(string carrier)
        {
            switch (carrier)
            {
                case "校园网":
                    return "1";
                case "中国移动":
                    return "2";
                case "中国电信":
                    return "3";
                case "中国联通":
                    return "4";
                default:
                    return "0";
            }
        }

        public RestRequest GenerateFirstAuth(string _ip)
        => new RestRequest("/login").AddJsonBody(
                new AuthRequest
                {
                    channel = getChannel(carrier),
                    ifautologin = "0",
                    pagesign = "firstauth",
                    password = this.password,
                    username = this.username,
                    usripadd = _ip
                });
        public RestRequest GenerateSecondAuth(string _ip)
        => new RestRequest("/login").AddJsonBody(
                new AuthRequest
                {
                    channel = getChannel(carrier),
                    ifautologin = "0",
                    pagesign = "secondauth",
                    password = this.password,
                    username = this.username,
                    usripadd = _ip
                }
    );

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

    public class WrongData
    {
        public string text { get; set; }
    }
    public class  ResponseResult
    {
        public int code { get; set; }

        public string message { get; set; }
        public WrongData data { get; set; }






    }
}