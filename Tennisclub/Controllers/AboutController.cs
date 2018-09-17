using System.Web.Mvc;
using Tennisclub.DAL;

namespace Tennisclub.Controllers
{
    public class AboutController : Controller
    {
        private TennisClubCtx db = new TennisClubCtx();
        public ActionResult Index()
        {

            var employees = db.Employees;
            return View(employees);
        }
	}
}