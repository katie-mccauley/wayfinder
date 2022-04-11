using System;
using System.Collections.Generic;
using wayfinder.Models;
using wayfinder.Repositories;

namespace wayfinder.Services
{
  public class TripsService
  {
    private readonly TripsRepository _tr;

    public TripsService(TripsRepository tr)
    {
      _tr = tr;
    }

    internal List<Trips> GetAll()
    {
      return _tr.GetAll();
    }
  }
}