using E_CommerceWebsiteusingWebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_CommerceWebsiteusingWebapi.Controllers
{
    public class CatApiController : ApiController
    {
        WebContext db = new WebContext();
        [HttpGet]
        public IHttpActionResult catGet()
        {
            List<tbl_Admin> list = db.tbl_Admin.ToList();
            return Ok(list);
        }


    }
}
