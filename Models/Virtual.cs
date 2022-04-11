using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wayfinder.Interfaces;

namespace wayfinder.Models
{
  public class Virtual<T> : IRepoItem<T>
  {
    public T id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string CreatorId { get; set; }
  }
}