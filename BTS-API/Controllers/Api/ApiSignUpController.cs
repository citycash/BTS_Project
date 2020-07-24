using BLL;
using Public_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BTS_API.Controllers.Api
{
    public class ApiSignUpController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage signup(MUser Model)
        {
            try
            {
                UserBLL bll = new UserBLL();
                var Data = bll.CreateUser(Model);
                var Token = GetToken("https://localhost:44353/", Model.Username, Model.Password);
                return Request.CreateResponse(HttpStatusCode.OK, new { email =  Data[0].Email, token = Token, username = Data[0].Username});
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        private string GetToken(string url, string userName, string password)
        {
            var pairs = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>( "grant_type", "password" ),
                        new KeyValuePair<string, string>( "username", userName ),
                        new KeyValuePair<string, string> ( "Password", password )
                    };
            var content = new FormUrlEncodedContent(pairs);
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url + "Token", content).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
