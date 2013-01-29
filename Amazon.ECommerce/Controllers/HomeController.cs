using System.Web.Mvc;
using Amazon.ECommerce.Components.Sales;
using Amazon.InternalMessages.Sales;

namespace Amazon.ECommerce.Controllers
{
    public class HomeController : Controller
    {

        public ISubmitOrderSender SubmitOrderSender { get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            SubmitOrderSender.Send(new SubmitOrder());

            return View();
        }
    }
}
