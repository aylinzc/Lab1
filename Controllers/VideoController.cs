using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            //Consultar la información en la base de datos
            ViewData["Video"] = BaseHelper.ejecutarConsulta("Select * from video", CommandType.Text);
            return View();
        }

    }
}
