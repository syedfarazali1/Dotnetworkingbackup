using crudappwithwebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace crudappwithwebapi.Controllers
{
    public class MvCController : Controller
    {
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<staff> staffs = new List<staff>();
            client.BaseAddress = new Uri("https://localhost:44374/api/WebApi");
            var response = client.GetAsync("WebApi");
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<staff>>();
                display.Wait();
                staffs = display.Result;
            }
            return View(staffs);
        }
        [HttpGet]
        public ActionResult Create()
        {
             return View();
        }



        [HttpPost]
        public ActionResult Create(staff sss)
        {

            client.BaseAddress = new Uri("https://localhost:44374/api/WebApi");
            var response = client.PostAsJsonAsync<staff>("WebApi", sss);
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create");
        }
        
        [HttpGet]
        public ActionResult Details(int id)
        {
            staff stf = null;
            client.BaseAddress = new Uri("https://localhost:44374/api/WebApi");
            var response = client.GetAsync("WebApi?id=" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<staff>();
                display.Wait();
                stf = display.Result;
            }
            return View(stf);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            staff stf = null;
            client.BaseAddress = new Uri("https://localhost:44374/api/WebApi");
            var response = client.GetAsync("WebApi?id=" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<staff>();
                display.Wait();
                stf = display.Result;
            }
            return View(stf);
        }
        [HttpPost]
        public ActionResult Edit(staff sss)
        {

            client.BaseAddress = new Uri("https://localhost:44374/api/WebApi");
            var response = client.PutAsJsonAsync<staff>("WebApi", sss);
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            staff stf = null;
            client.BaseAddress = new Uri("https://localhost:44374/api/WebApi");
            var response = client.GetAsync("WebApi?id=" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<staff>();
                display.Wait();
                stf = display.Result;
            }
            return View(stf);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            client.BaseAddress = new Uri("https://localhost:44374/api/WebApi");
            var response = client.DeleteAsync("WebApi/"+id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Delete");
        }
    }
}