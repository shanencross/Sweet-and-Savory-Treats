using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using SweetAndSavoryTreats.Models;

namespace SweetAndSavoryTreats.Controllers
{
  public class TreatsController : Controller
  {
    private readonly SweetAndSavoryTreatsContext _db;

    public TreatsController(SweetAndSavoryTreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> treats = _db.Treats.ToList();
      return View(treats);
    }

    [Authorize]
    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View();
    }

    [HttpPost]
    [Authorize]
    public ActionResult Create(Treat treat, int flavorId)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      if (flavorId != 0)
      {
        _db.FlavorTreats.Add(new FlavorTreat() { FlavorId=flavorId, TreatId=treat.TreatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Treat thisTreat = _db.Treats
        .Include(treat => treat.FlavorTreats)
        .ThenInclude(flavorTreat => flavorTreat.Flavor)
        .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [Authorize]
    public ActionResult Edit(int id)
    {
      Treat thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost]
    [Authorize]
    public ActionResult Edit(Treat treat)
    {
      _db.Entry(treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [Authorize]
    public ActionResult Delete(int id)
    {
      Treat thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost, ActionName("Delete")]
    [Authorize]
    public ActionResult DeleteConfirmed(int id)
    {
      Treat thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      if (id != 0)
      {
        _db.Treats.Remove(thisTreat);
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [Authorize]
    public ActionResult AddFlavor(int id)
    {
      Treat thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(thisTreat);
    }

    [HttpPost]
    [Authorize]
    public ActionResult AddFlavor(Treat treat, int flavorId)
    {
      if (flavorId != 0)
      {
        _db.FlavorTreats.Add(new FlavorTreat() { FlavorId=flavorId, TreatId=treat.TreatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new { id=treat.TreatId });
    }
  }
}