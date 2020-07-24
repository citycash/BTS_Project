using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTS_API
{
    public class UserAuthentication :IDisposable
    {
        public bool ValidateUser(string Username, string Password)
        {
            UserBLL Bll = new UserBLL();
            return Bll.CheckUser(Username, Password);
        }

        public void Dispose()
        {

        }
    }
}