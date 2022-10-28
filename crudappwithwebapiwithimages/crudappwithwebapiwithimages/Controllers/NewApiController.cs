using crudappwithwebapiwithimages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace crudappwithwebapiwithimages.Controllers
{
   

    public class NewApiController : ApiController
    {
       WebContaxt db = new WebContaxt();
        [HttpGet]
        public IHttpActionResult Index()
        {
           var list = db.Infoes.ToList();
            return Ok(list);
        }  
        [HttpGet]
        public IHttpActionResult Index(int id)
        {
            
           var list = db.Infoes.Find(id);
            if (list == null)
            {
                return Ok("error");
            }
            return Ok(list);
        }  
        [HttpPost]
        public IHttpActionResult Create(Info infoss)
        {
            db.Infoes.Add(infoss);
            db.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Edit(Info e)
        {
            var list = db.Infoes.Where(x => x.ID == e.ID).FirstOrDefault();
            list.ID = e.ID;
            list.Contact = e.Contact;
            list.Email = e.Email;
            list.Name = e.Name;
            list.Images = e.Images;
            db.SaveChanges();
            return Ok();
        }
    }
}
