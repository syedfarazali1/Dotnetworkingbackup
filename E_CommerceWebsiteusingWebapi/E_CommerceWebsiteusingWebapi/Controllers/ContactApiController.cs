using E_CommerceWebsiteusingWebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
namespace E_CommerceWebsiteusingWebapi.Controllers
{
    public class ContactApiController : ApiController
    {
        WebContext db = new WebContext();
        [HttpGet]
        public IHttpActionResult UserGet()
        {
            List<tbl_Contact> list = db.tbl_Contact.Include("tbl_User").ToList();

            return Ok(list);
        }
    }
}
