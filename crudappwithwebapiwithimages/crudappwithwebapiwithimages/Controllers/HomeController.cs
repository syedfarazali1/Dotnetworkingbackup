using crudappwithwebapiwithimages.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace crudappwithwebapiwithimages.Controllers
{
    public class HomeController : Controller
    {
        HttpClient hc = new HttpClient();
        public ActionResult Index()
        {
            List<Info> infos = new List<Info>();
            hc.BaseAddress = new Uri("https://localhost:44313/api/Newapi");
            var response = hc.GetAsync("Newapi");
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Info>>();
                display.Wait();
                infos = display.Result;
            }
            return View(infos);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
            public ActionResult Create(Info info , HttpPostedFileBase file)
        {
            var imgpath = Server.MapPath("~/Images/");
            file.SaveAs(Path.Combine(imgpath, file.FileName));
            info.Images = file.FileName;
            hc.BaseAddress = new Uri("https://localhost:44313/api/Newapi");
            var response = hc.PostAsJsonAsync("Newapi", info);
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        { 
            Info e = null;
            hc.BaseAddress = new Uri("https://localhost:44313/api/Newapi/"+id);
            var response = hc.GetAsync("WebApi?id=" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Info>();
                display.Wait();
                e = display.Result;
            }
            return View(e);
        }  
        [HttpGet]
        public ActionResult Eidt(int id)
        { 
            Info e = null;
            hc.BaseAddress = new Uri("https://localhost:44313/api/Newapi/"+id);
            var response = hc.GetAsync("WebApi?id=" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Info>();
                display.Wait();
                e = display.Result;
            }
            return View(e);
        }
        [HttpPost]
        public ActionResult Edit(Info info, HttpPostedFileBase file)
        {
            var imgpath = Server.MapPath("~/Images/");
            file.SaveAs(Path.Combine(imgpath, file.FileName));
            info.Images = file.FileName;
            hc.BaseAddress = new Uri("https://localhost:44313/api/Newapi");
            var response = hc.PutAsJsonAsync("Newapi", info);
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
