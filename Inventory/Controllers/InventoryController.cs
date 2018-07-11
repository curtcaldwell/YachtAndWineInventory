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
    [HttpGet("/wine")]
    public ActionResult Wines()
    {
      return View();
    }
    [HttpPost("/wine/list")]
    public ActionResult GetWine()
    {
      Wine newWine = new Wine(Request.Form["wine"], Request.Form["yachtId"]);
      newWine.Save();
      return View("WineList", Wine.GetAll());
    }

    [HttpPost("/yacht/list")]
    public ActionResult GetYacht()
    {
      Yacht newYacht = new Yacht(Request.Form["yacht"]);
      newYacht.Save();
      return View("YachtList", Yacht.GetAll());
    }
    [HttpGet("/wine/list/{id}/update")]
    public ActionResult UpdateForm(int id)
    {
      Wine thisWine = Wine.Find(id);
      return View(thisWine);
    }

    [HttpPost("/wine/list/{id}/update")]
    public ActionResult Update(int id)
    {
      Wine thisWine = Wine.Find(id);
      thisWine.Edit(Request.Form["newname"]);
      return RedirectToAction("WineList");
    }
  }
}
