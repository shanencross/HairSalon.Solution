using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistsController: Controller
  {
    HairSalonContext _db;
    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }
  }
}