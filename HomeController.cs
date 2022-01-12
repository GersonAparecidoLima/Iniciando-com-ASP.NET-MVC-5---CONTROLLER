using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // ActionResult e um generico        
        public ActionResult Index()
        {
            return View();
            // return Content("ops");
            //return Redirect("http://www.google.com");
        }

        //retorna um conteudo
        // caso queira usar ActionResult pode
        public ContentResult ContentResult() {
            return Content("ops");
        }

        //download
        // caso queira usar ActionResult pode
        public FileContentResult FileContentResult() {
            byte[] foto = System.IO.File.ReadAllBytes(Server.MapPath("/Content/Img/Icone-Carta.jpg"));
            return File(foto,contentType: "Img/jpg", fileDownloadName: "Icone-Carta.jpg");
            
        }

        //resultado não autorizado
        // caso queira usar ActionResult pode
        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }

        //AllowGet permitir um Get
        // caso queira usar ActionResult pode
        public JsonResult JsonResult() {
            return Json(data:"teste: TesteOps", JsonRequestBehavior.AllowGet );
        }

        // caso queira usar ActionResult pode
        // caso queira usar ActionResult pode
        public RedirectResult RedirectResult() {

            return Redirect("http://www.google.com");
            //return new RedirectResult( url:"http://www.google.com");
        }

        // caso queira usar ActionResult pode
        public RedirectToRouteResult RedirectToRouteResult(){

            /*
            return RedirectToRoute(new {
                Controller = "Home",
                action = "About"            
            });
            */
            // ou algo mas simples
            // return RedirectToAction("About");
            return RedirectToAction("Home", controllerName: "About");

        }

        // caso queira usar ActionResult pode
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
            
        }

        // caso queira usar ActionResult pode
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}