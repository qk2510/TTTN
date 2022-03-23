using TTTN_KimQuyen.Models;
using System.Linq;
using System.Web.Mvc;

namespace TTTN_KimQuyen.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        private Connect db = new Connect();

        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            ViewBag.CountOrderSuccess = db.Order.Where(m => m.Status == 3).Count();
            ViewBag.CountOrderCancel = db.Order.Where(m => m.Status == 1).Count();
            ViewBag.CountContactDoneReply = db.Contact.Where(m => m.Flag == 0).Count();
            ViewBag.CountUser = db.User.Where(m => m.Status != 0).Count();
            return View();
        }
    }
}