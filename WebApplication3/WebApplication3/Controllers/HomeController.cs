using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        WebContext db = new WebContext(); 
        public ActionResult Index()
        {
            List<ORDERS> ORDERS = db.ORDERs.Include("Products").ToList();
            return View(ORDERS);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Order_product order_Product = new Order_product();
            order_Product.GetProducts = db.Products.ToList();
            return View(order_Product);
        }
        [HttpPost]
        public ActionResult Create(string name,HttpPostedFileBase img,HttpPostedFileBase vid,HttpPostedFileBase ado,int prodi)
        {
            ORDERS od = new ORDERS();
            od.Name = name;
            od.products = db.Products.Find(prodi);
            if (img != null)
            {
                string _imgfilename = Path.GetFileName(img.FileName);
                string _path = Path.Combine(Server.MapPath("~/Uploadedimage"), _imgfilename);
                img.SaveAs(_path);
                od.Images = _imgfilename;
            }

            if (vid != null)
            {
                string _vidfilename = Path.GetFileName(img.FileName);
                string _path = Path.Combine(Server.MapPath("~/Uploadedvideo"), _vidfilename);
                vid.SaveAs(_path);
                od.video = _vidfilename;
            }
            if (ado != null)
            {
                string _adofilename = Path.GetFileName(ado.FileName);
                string _path = Path.Combine(Server.MapPath("~/UploadedAudio"), _adofilename);
                vid.SaveAs(_path);
                od.audio = _adofilename;
            }
            db.ORDERs.Add(od);
            db.SaveChanges();
            return View(od);



        }
    }
}