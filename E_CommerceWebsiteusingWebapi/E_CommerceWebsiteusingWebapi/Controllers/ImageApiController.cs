using E_CommerceWebsiteusingWebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_CommerceWebsiteusingWebapi.Controllers
{
    public class ImageApiController : ApiController
    {
        WebContext db = new WebContext();
        [HttpGet]
        public IHttpActionResult UserGet()
        {
            List<tbl_Images> list = db.tbl_Images.ToList();
            return Ok(list);
        }
    }
}
