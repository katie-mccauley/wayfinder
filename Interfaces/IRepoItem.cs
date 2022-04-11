using System;

namespace wayfinder.Interfaces
{
  public interface IRepoItem<T>
  {
    public T id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}