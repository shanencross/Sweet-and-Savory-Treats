using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using SweetAndSavoryTreats.Models;

namespace SweetAndSavoryTreats.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly SweetAndSavoryTreatsContext _db;

    public FlavorsController(SweetAndSavoryTreatsContext db)
    {
      _db = db;
    }
  }
}