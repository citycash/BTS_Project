using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DbTrans
    {
        static string connStr = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ToString();

        public static DAL.DbTransaction defaultTransaction()
        {
            return new DAL.DbTransaction(connStr);
        }

    }

    public static class DbTransISPC
    {
        static string connStr = ConfigurationManager.ConnectionStrings["ISPCConn"].ToString();

        public static DAL.DbTransaction defaultTransaction()
        {
            return new DAL.DbTransaction(connStr);
        }


    }
    public static class DbLogin
    {
        static string connStr = ConfigurationManager.ConnectionStrings["ConStringLogin"].ToString();
        public static DAL.DbTransaction defaultTransaction()
        {
            return new DAL.DbTransaction(connStr);
        }

    }
}
