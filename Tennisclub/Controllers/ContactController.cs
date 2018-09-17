using System.Configuration;
using System.Net.Mail;
using System.Web.Mvc;

namespace Tennisclub.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Send()
        {
            string message = "";

            message += "<table>" ;
            message += "<tr><td>test</td></tr>";
            message += "</table>";

            MailMessage mm = new MailMessage("loganclass@alloftheweb.net", "mark_coding@hotmail.com");
            mm.CC.Add("lvaughn@cisp.com");
            mm.Subject = "New Inquery";
            mm.IsBodyHtml = true;
            mm.Body = message;
            
            SmtpClient sc = new SmtpClient(ConfigurationSettings.AppSettings["MailServer"].ToString());
            sc.Send(mm);

            return View();
        }
    }
}