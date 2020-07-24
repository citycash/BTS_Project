using DAL;
using Public_Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Shopping
    {
        private readonly DbTransaction dbtran = DbTrans.defaultTransaction();
        public List<MShopping> InsertData(MShopping Model)
        {
            try
            {
                return dbtran.DbToList<MShopping>("SP_Add_Shopping", new
                {
                    Name = Model.Name,
                    CreatedDate = Model.CreatedDate
                }, true);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<MShopping> GetAllData()
        {
            try
            {
                return dbtran.DbToList<MShopping>("SP_GET_Shopping", true);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<MShopping> GetDataByID(int ID)
        {
            try
            {
                return dbtran.DbToList<MShopping>("SP_GET_Shopping_ByID", new
                {
                    ID = ID
                }, true);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<MShopping> UpdateShopping(MShopping Model)
        {
            try
            {
                return dbtran.DbToList<MShopping>("SP_UPDATE_Shopping", new
                {
                    ID = Model.Id,
                    Name = Model.Name,
                    CreatedDate = Model.CreatedDate,
                }, true);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string DeleteShooping(int ID)
        {
            try
            {
                return dbtran.DbToString("SP_DELETE_Shopping", new
                {
                    ID = ID
                }, true);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
