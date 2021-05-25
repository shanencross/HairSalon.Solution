using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController: Controller
  {
    HairSalonContext _db;
    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }
  }
}