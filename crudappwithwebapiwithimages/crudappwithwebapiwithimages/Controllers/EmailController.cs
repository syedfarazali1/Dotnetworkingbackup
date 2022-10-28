using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace crudappwithwebapiwithimages.Controllers
{
    public class EmailController : Controller
    {
        public ActionResult Form()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Form(string receiver,string subject, string message , string sender)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("syedfarazali066@gmail.com","Demo Test");
                    var recievermail = new MailAddress(receiver, "Receiver");
                    
                    var password = "Syedfarazali";
                    var sub = subject;
                    var body = message;

                    var stmp = new SmtpClient { 
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address,password)

                    };

                    using (var mass = new MailMessage(sender, receiver)
                    {

                        Subject = subject,
                        Body = body

                    })
                    {
                        stmp.Send(mass);
                    }
                    return View();
                
                }
               
            }
            catch (Exception)
            {
                ViewBag.Error = "Error";
            }
            return View();
        }
    }
}