using Mynewaspwebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mynewaspwebapi.Controllers
{
    public class ConsumeController : Controller
    {
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<employee> list = new List<employee>();
            client.BaseAddress = new Uri("http://localhost:55008/api/Newapi");
            var response = client.GetAsync("Newapi");
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<employee>>();
                display.Wait();
                list = display.Result;
            }
            return View(list);
        }
    }
}