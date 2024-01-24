using System;
using System.Collections.Generic;

namespace TravelLog.Models
{
  public class Places
  {
    public string City { get; set; }
    public DateTime VisitDate { get; set; }
    public int Rating { get; set; }
    private static List<Places> _instances = new List<Places> {};
    public Places(string city, DateTime visitDate, int rating = 0)
    {
      City = city;
      VisitDate = visitDate;
      Rating = rating;
      _instances.Add(this);
    }

    public static List<Places> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}