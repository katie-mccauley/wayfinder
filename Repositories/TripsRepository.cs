using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using wayfinder.Models;

namespace wayfinder.Repositories
{

  public class TripsRepository
  {
    private readonly IDbConnection _db;
    public TripsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Trips> GetAll()
    {
      string sql = @"
        SELECT * FROM trips;
      ";
      return _db.Query<Trips>(sql).ToList();
    }
  }
}