using E_multishopwebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_multishopwebapi.Controllers
{
    public class catapiController : ApiController
    {
        E_commerce_ProjectEntities db = new E_commerce_ProjectEntities();
        public IHttpActionResult get()
        {
            var list = db.SPContact();

            return Ok(list);
            
        }
    }
}
