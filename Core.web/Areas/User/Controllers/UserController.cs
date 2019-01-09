using Core.Agent.Interface;
using Microsoft.AspNetCore.Mvc;
namespace Core.web.Areas.User.Controllers
{
    public class UserController : Controller
    {
        private IUser user;

        public UserController(IUser _user)
        {
            this.user = _user;
        }
        public IActionResult Indexe()
        {
            var res = user.GetUserList();
            ViewBag.data = res;
            return View();
        }
        [HttpPost]
        public JsonResult Delete(int id)
        {
            ViewBag.data = user.DeleteUser(id);
            return Json(new { msg = "ok" });
        }
        [HttpGet]
        public JsonResult GetUserList()
        {
            var res = user.GetUserList();
            return Json(new { msg = "ok", data = res });
        }
    }
}