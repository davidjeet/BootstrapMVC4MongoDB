using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Infrastructure.DataAccess;

namespace WebUI.Controllers
{
    public class HomeController : BootstrapMvcSample.Controllers.BootstrapBaseController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            MongoDB.Driver.DatabaseStatsResult stats = null;
            try
            {
                stats = MongoHelper.Current.Database.GetStats();
            }
            catch (Exception ex)
            {
                Error("There were errors: " + ex);
            }
            return View(stats);
        }

    }
}
