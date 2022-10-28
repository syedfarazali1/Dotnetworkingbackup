using crudappwithwebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace crudappwithwebapi.Controllers
{
    public class WebApiController : ApiController
    {
        WebContext db = new WebContext();
        [HttpGet]
        public IHttpActionResult Index()
        {
            var list = db.staffs.ToList();
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult Getstaffbyid(int id)
        {
            var list = db.staffs.Find(id);
            return Ok(list);
        }

        [HttpPost]
        public IHttpActionResult Create(staff stf)
        {
            db.staffs.Add(stf);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update(staff stf)
        {
            db.Entry(stf).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            //var stfs = db.staffs.Where(x => x.ID == stf.ID).FirstOrDefault();
            //if (stf != null)
            //{
            //    stfs.ID = stf.ID;
            //    stfs.St_Adress = stf.St_Adress;
            //    stfs.St_Desination = stf.St_Desination;
            //    stfs.St_Gender = stf.St_Gender;
            //    stfs.St_Name = stf.St_Name;
            //    stfs.St_salary = stf.St_salary;
            //    db.SaveChanges();

            //}
            //else
            //{
            //    return NotFound();
            //}
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete (int id)
        {
            var stfs = db.staffs.Where(x => x.ID == id).FirstOrDefault();
            db.Entry(stfs).State = System.Data.Entity.EntityState.Deleted;
            //db.staffs.Remove(stfs);
            db.SaveChanges();
            return Ok();
        }
    }
}
