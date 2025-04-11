using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRVTextToImage;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;


namespace MVC_Online_invoice.Controllers
{
    public class AccountController : Controller
    {

      
        //
        // GET: /Account/


        [HttpGet]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")] // This is for output cache false
        public FileResult GetCaptchaImage()
        {
            CaptchaRandomImage CI = new CaptchaRandomImage();
            string val = System.DateTime.Now.ToString("yyyyMMddHHmmssffff");
            this.Session["CaptchaImageText"] = val.Substring(10, 4); ///CI.GetRandomString(5); // here 5 means I want to get 5 char long captcha
            //CI.GenerateImage(this.Session["CaptchaImageText"].ToString(), 300, 75);
            // Or We can use another one for get custom color Captcha Image 
            CI.GenerateImage(this.Session["CaptchaImageText"].ToString(), 300, 75, Color.DarkGray, Color.White);
            MemoryStream stream = new MemoryStream();
            CI.Image.Save(stream, ImageFormat.Png);
            stream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(stream, "image/png");
        }

        [HttpGet]
        public ActionResult Default()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ERP()
        {
            return View();
        }

        [HttpGet]
        public ActionResult login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }


     

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            try
            {
                FormsAuthentication.SignOut();
            }
            catch
            {
                return RedirectToAction("login", "Account");
            }
            return RedirectToAction("login", "Account");
        }


        [HttpGet]
        public ActionResult Accounting()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Association()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Clients()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public ActionResult crm()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Customize_application_developement()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Developement_Services()
        {
            return View();
        }
        [HttpGet]
        public ActionResult e_goverance()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Enquiry()
        {
            return View();
        }
        [HttpGet]
        public ActionResult It_consulting()
        {
            return View();

        }
        [HttpGet]
        public ActionResult Product()
        {
            return View();
        }

        [HttpGet]
        public ActionResult scm()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Software_Services()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Web_based_Services()
        {
            return View();
        }


        [HttpGet]
        public ActionResult mypage()
        {
            return View();
        }

        public ActionResult itservicepage()
        {
            return View();
        }

        public ActionResult infraservicepage()
        {
            return View();
        }

        public ActionResult cctv_security()
        {
            return View();
        }


        public ActionResult epabx_ip()
        {
            return View();
        }

        public ActionResult Boom_barrier()
        {
            return View();
        }
        public ActionResult audio_conference_system()
        {
            return View();
        }

        public ActionResult fiber_optics()
        {
            return View();
        }

        public ActionResult networking_lan()
        {
            return View();
        }
        public ActionResult pa_system()
        {
            return View();
        }

        public ActionResult ourservicespage()
        {
            return View();
        }
        public ActionResult ourserviceinfra()
        {
            return View();
        }

    }
}
