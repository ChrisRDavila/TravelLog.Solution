using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelLog.Models;
using System;
using System.Collections.Generic;

namespace TravelLog.Tests
{
  [TestClass]
  public class PlacesTests

  {
    [TestMethod]
    public void PlacesConstructor_CreatesInstanceOfPlaces_Places()
    {
      DateTime testDate = new DateTime(2020, 1, 1);
      Places newPlaces = new Places("Portland", testDate);
      Assert.AreEqual(typeof(Places), newPlaces.GetType());
    }

    [TestMethod]
    public void GetCity_ReturnsCity_String()
    {
      //Arrange
      DateTime testDate = new DateTime(2020, 1, 1);
      string city = "Portland";
      //Act
      Places newPlaces = new Places(city, testDate);
      string result = newPlaces.City;
      //Assert
      Assert.AreEqual(city, result);
    }

    [TestMethod]
    public void SetCity_SetCity_String()
    {
      //Arrange
      DateTime testDate = new DateTime(2020, 1, 1);
      string city = "Portland";
      Places newPlaces = new Places(city, testDate);
      //Act
      string updatedCity = "Seattle";
      newPlaces.City = updatedCity;
      string result = newPlaces.City;
      //Assert
      Assert.AreEqual(updatedCity, result);
    }

    [TestMethod]
    public void GetVisitDate_ReturnsVisitDate_DateTime()
    {
      //Arrange
      string city = "Portland";
      DateTime visitDate = new DateTime(2020, 1, 1);
      Places newPlaces = new Places(city, visitDate);
      //Act
      DateTime result = newPlaces.VisitDate;
      //Assert
      Assert.AreEqual(visitDate, result);
    }
  }
}    