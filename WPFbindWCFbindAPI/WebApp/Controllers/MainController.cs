﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.ServiceReference1;

namespace WebApp.Controllers
{
    public class MainController : ApiController
    {
       
        Service1Client WCFclient = new Service1Client();
        //GET: api/Main
        public string Get()
        {
           
            string result = WCFclient.GetDataAsync(5).Result;
        
            return result;
        }
        //GET: api/Main/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Main
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Main/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Main/5
        public void Delete(int id)
        {
        }
    }
}
