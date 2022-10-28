using Mynewaspwebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mynewaspwebapi.Controllers
{
    public class NewapiController : ApiController
    {
        farazEntities db = new farazEntities();
        [HttpGet]   
        public IHttpActionResult Action()
        {
            List<employee> obj = db.employees.ToList();
            return Ok(obj);

        }
        [HttpGet]   
        public IHttpActionResult Action(int id)
        {
            var obj = db.employees.Where(x => x.S_ == id).FirstOrDefault();
            return Ok(obj);

        }
    }
}
