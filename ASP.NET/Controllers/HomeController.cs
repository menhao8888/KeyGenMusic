using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //后台往前台扔了一条数据
            ViewData["key"] = DateTime.Now.ToString();
            return View();
        }

        public ActionResult FileContenResultDemo()
        {
            FileStream fs = new FileStream(Server.MapPath(@"~/Content/images/KeyGenMusic.jpg"), FileMode.Open, FileAccess.Read);

            byte[] buffer = new byte[Convert.ToInt32(fs.Length)];

            fs.Read(buffer, 0, Convert.ToInt32(fs.Length));
            return File(buffer, @"image/gif");


        }



        public ActionResult About()
        {
            // ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult introduce()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }


        
      public ActionResult ViewPage1()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult PlayMusic()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public partial class admin_Default : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                string path = Server.MapPath("/Music/");
                DirectoryInfo di = new DirectoryInfo(path);
                //找到该目录下的文件 
                FileInfo[] fis = di.GetFiles();
                foreach (FileInfo fi in fis)
                {
                    Response.Write(fi.Name);
                    Response.Write("<br>");
                }
            }
        }



    }
}