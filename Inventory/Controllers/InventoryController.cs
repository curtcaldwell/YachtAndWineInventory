using Microsoft.AspNetCore.Mvc;
using Inventory.Models;

namespace Inventory.Controllers
{
  public class InventoryController : Controller
  {
    [HttpGet("/yacht")]
    public ActionResult Yachts()
    {
      return View();
    }
    // [HttpGet("/wine")]
    // public ActionResult Wine()
    // {
    //   return View();
    // }
    // [HttpPost("/wine/list")]
    // public ActionResult GetWine()
    // {
    //   Item newItem = new Item(Request.Form["wine"]);
    //   newItem.Save();
    //   return View("WineList", Wine.GetAll());
    // }

    [HttpPost("/yacht/list")]
    public ActionResult GetYacht()
    {
      Yacht newYacht = new Yacht(Request.Form["yacht"]);
      newYacht.Save();
      return View("YachtList", Yacht.GetAll());
    }
}
}
