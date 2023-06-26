using Microsoft.AspNetCore.Mvc;
using shoppingAPP_mvc.Models;
namespace shoppingAPP_mvc.Controllers
{
    public class productsController : Controller
    {
     
        public IActionResult aboutAPP()
        {
            //collect data from Model, save it in ViewBag and it will be passed to view file
            ViewBag.appName = "Shopping APP";
            ViewBag.appDeveloper = "Nikhil Shah";
            ViewBag.appTeamSize = 20;
            ViewBag.appIsLive = false;
            return View();
        }

        public IActionResult ProductCategory()
        {
            //collect data from Model 
            List<string> categoryList = new List<string>() { "TShirts", "Shoes", "Head-Phones", "Speakers", "Tie", "Makeup" };
            ViewBag.productCategory = categoryList;
            return View();
        }

        public IActionResult ProductList()
        {
            Products pObj = new Products();
            ViewBag.pList = pObj.GetAllProducts();
            return View();
        }
    }
}
