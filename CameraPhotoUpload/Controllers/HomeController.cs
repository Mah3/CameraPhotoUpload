using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUpload.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public void UploadPhoto(HttpPostedFileBase webcamPhoto)
        {
            // Verify that the user selected a file
            if (webcamPhoto != null && webcamPhoto.ContentLength > 0)
            {
                var fileName = Guid.NewGuid().ToString() + ".jpg";
                var filePath = Path.Combine(Server.MapPath("~/Upload"), fileName);
                webcamPhoto.SaveAs(filePath);
            }
        }



        [ValidateAntiForgeryToken]
        [HttpPost]
        public void Index(string webcamData)
        {
            if (webcamData != null)
            {
                var bytes = Convert.FromBase64String(webcamData);
                var fileName = Guid.NewGuid().ToString() + ".jpg";
                var filePath = Path.Combine(Server.MapPath("~/Upload"), fileName);
                using (var imageFile = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.Write(bytes, 0, bytes.Length);
                    imageFile.Flush();
                }
            }


        }
    }
}

