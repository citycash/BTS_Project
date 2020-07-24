using DAL;
using Public_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        private readonly DbTransaction dbtran = DbTrans.defaultTransaction();
        public bool CheckUser(string Username, string Password)
        {
            try
            {
                string Data = dbtran.DbToString("SP_Check_User", new
                {
                    Username = Username,
                    Password = Password
                }, true);

                if (Data == "FALSE") return false;
                
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<MUser> CreateUser(MUser Model)
        {
            try
            {
                return dbtran.DbToList<MUser>("SP_CREATE_User", new
                {
                    Username = Model.Username,
                    Email = Model.Email,
                    Password = Model.Password,
                    Phone = Model.Phone,
                    Address = Model.Address,
                    City = Model.City,
                    Country = Model.Country,
                    Name = Model.Name,
                    PostCode = Model.PostCode,
                }, true);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
