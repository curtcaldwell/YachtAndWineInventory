using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;

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
    [HttpGet("/wine/list")]
    public ActionResult WineList()
    {
      List<Wine> allWines = Wine.GetAll();
      return View(allWines);
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
    [HttpGet("/Inventory/{id}/update")]
    public ActionResult UpdateForm(int id)
    {
      Wine thisWine = Wine.Find(id);
      return View(thisWine);
    }

    [HttpPost("/Inventory/{id}/update")]
    public ActionResult Update(int id)
    {
      Wine thisWine = Wine.Find(id);
      thisWine.Edit(Request.Form["newname"]);
      return RedirectToAction("WineList");
    }

    [HttpPost("/wine/delete")]
    public ActionResult DeleteOneWine(int wineId)
    {
      Wine.Find(wineId).Delete();
      return RedirectToAction("WineList");
    }
  }
}
