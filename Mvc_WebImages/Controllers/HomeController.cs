using System.Web.Helpers;
using System.Web.Mvc;

namespace Mvc_WebImages.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public void GetImagem()
        {
            WebImage webImage = new WebImage("~/Imagens/ryoji.png");
            webImage.Resize(300, 300);
            webImage.FileName = "ryoji.png";
            webImage.Write();
        }


    }
}