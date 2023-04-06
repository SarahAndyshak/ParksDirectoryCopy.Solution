using Microsoft.AspNetCore.Mvc;
using ParksExplorer.Models;
using Newtonsoft.Json.Linq;


namespace ParksExplorer.Controllers;

public class ParksController : Controller
{
  public IActionResult Index()
  {
    List<Park> parks = Park.GetParks();
    return View(parks);
  }

  public IActionResult Details(int id)
  {
    Park park = Park.GetDetails(id);
    return View(park);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Park park)
  {
    if (!ModelState.IsValid)
    {
      return View(park);
    }
    else
    {
    Park.Post(park);
    return RedirectToAction("Index");
    }
  }

  public ActionResult Edit(int id)
  {
    Park park = Park.GetDetails(id);
    return View(park);
  }

  [HttpPost]
  public ActionResult Edit(Park park)
  {
    Park.Put(park);
    return RedirectToAction("Details", new { id = park.ParkId });
  }

  public ActionResult Delete(int id)
  {
    Park park = Park.GetDetails(id);
    return View(park);
  }

  [HttpPost, ActionName ("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Park.Delete(id);
    return RedirectToAction("Index");
  }

// original search function
  // [HttpPost, ActionName("Search")]
  // public IActionResult Search(string name)
  // {
  //   List<Park> parks = Park.GetParks();
  //   List<Park> result = parks.FindAll(planet => planet.Name.ToLower().Equals(name.ToLower()));
  //   return View(result);
  // }

  [HttpPost, ActionName("Search")]
  public IActionResult Search(string name)
  {
    List<Park> parks = Park.GetParks();
    List<Park> result = parks.FindAll(park => park.Name.ToLower().Contains(name.ToLower()));
    return View(result);
  }
}