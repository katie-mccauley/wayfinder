using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using wayfinder.Models;
using wayfinder.Services;

namespace wayfinder.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TripsController : ControllerBase
  {
    private readonly TripsService _ts;

    public TripsController(TripsService ts)
    {
      _ts = ts;
    }

    [HttpGet]
    public ActionResult<List<Trips>> GetAll()
    {
      try
      {
        List<Trips> trips = _ts.GetAll();
        return Ok(trips);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);

      }
    }
  }
}