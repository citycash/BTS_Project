using BLL;
using Public_Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BTS_API.Controllers.Api
{
    public class ApiShoppingController : ApiController
    {
        [HttpPost]        
        public HttpResponseMessage BuatShopping(string Name, string Date)
        {
            try
            {
                DateTime DateCreate = DateTime.Now;
                try
                {
                    DateCreate = DateTime.ParseExact(Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                }
                catch(Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
                Shopping Bll = new Shopping();
                MShopping Model = new MShopping()
                {
                    Name = Name,
                    CreatedDate = DateCreate,
                };
                var Data = Bll.InsertData(Model);
                return Request.CreateResponse(HttpStatusCode.OK, Data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetAllShopping()
        {
            try
            {
                Shopping Bll = new Shopping();
                var Data = Bll.GetAllData();
                return Request.CreateResponse(HttpStatusCode.OK, Data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        public HttpResponseMessage GetShoppingByID(int ID)
        {
            try
            {
                Shopping Bll = new Shopping();
                var Data = Bll.GetDataByID(ID);
                return Request.CreateResponse(HttpStatusCode.OK, Data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage DeleteShopping(int ID)
        {
            try
            {
                Shopping Bll = new Shopping();
                var Data = Bll.DeleteShooping(ID);
                return Request.CreateResponse(HttpStatusCode.OK, Data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage UpdateShopping(int ID, string Name, string Date)
        {
            try
            {
                DateTime DateCreate = DateTime.Now;
                try
                {
                    DateCreate = DateTime.ParseExact(Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
                Shopping Bll = new Shopping();
                MShopping Model = new MShopping()
                {
                    Id = ID,
                    Name = Name,
                    CreatedDate = DateCreate,
                };
                var Data = Bll.InsertData(Model);
                return Request.CreateResponse(HttpStatusCode.OK, Data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
