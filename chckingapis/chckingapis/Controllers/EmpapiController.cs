using chckingapis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace chckingapis.Controllers
{
    public class EmpapiController : ApiController
    {
        Webcontext db = new Webcontext();
        public IHttpActionResult Get()
        {
            var list = db.employees.ToList();
            return Ok(list);
        }
    }
}
