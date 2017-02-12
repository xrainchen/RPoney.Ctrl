using System.Collections.Generic;
using System.Web.Mvc;

namespace Poney.Ctrl.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(ParamModel model)
        {

            model.ReturnList = new List<ProductGame>();
            for (var i = 0; i < 10; i++)
            {
                model.ReturnList.Add(new ProductGame() { ProductGameId = "" + i, ProductGameName = "ProductGameName" + i, ProductGameBrandName = "ProductGameBrandName" + i });
            }
            return View(model);
        }
    }

    public class ParamModel
    {
        public List<ProductGame> ReturnList { get; set; }
        public string SelectedIds { get; set; }
    }
    public class ProductGame
    {
        public string ProductGameId { get; set; }
        public string ProductGameName { get; set; }
        public string ProductGameBrandName { get; set; }
    }
}