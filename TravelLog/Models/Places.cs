using System;

namespace TravelLog.Models
{
  public class Places
  {
    public string City { get; set; }
    public DateTime VisitDate { get; set; }
    public Places(string city, DateTime visitDate)
    {
      City = city;
      VisitDate = visitDate;
    }
  }
}