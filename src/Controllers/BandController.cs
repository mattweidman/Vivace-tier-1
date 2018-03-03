namespace todo.Controllers
{
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Models;

    public class BandController : Controller
    {
        // GET: Band/id
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Band band = await RepositoryHolder.Bands.GetItemAsync(id);
            if (band == null)
            {
                return HttpNotFound();
            }

            return Json(band, JsonRequestBehavior.AllowGet);
        }
    }
}