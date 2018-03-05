namespace vivace.Controllers
{
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Models;

    public class UserController : Controller
    {

        // GET: User/id
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            User user = await RepositoryHolder.Users.GetItemAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return Json(user, JsonRequestBehavior.AllowGet);
        }
    }
}