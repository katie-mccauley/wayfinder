using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wayfinder.Models
{
  public class Reservation : Virtual<int>
  {
    public int TripId { get; set; }
    public int Id { get; set; }

    public string Name { get; set; }
    public string ConfirmNum { get; set; }
    public string Address { get; set; }
    public DateTime Date { get; set; }
    public int Cost { get; set; }

  }
}