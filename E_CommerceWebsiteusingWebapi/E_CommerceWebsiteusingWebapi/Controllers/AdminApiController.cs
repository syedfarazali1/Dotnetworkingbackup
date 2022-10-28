using E_CommerceWebsiteusingWebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_CommerceWebsiteusingWebapi.Controllers
{
    public class AdminApiController : ApiController
    {
        WebContext db = new WebContext();
        [HttpGet]
        public IHttpActionResult Get()
        {
            List<tbl_Admin> list = db.tbl_Admin.ToList();
            return Ok(list);
        }
    }
}
