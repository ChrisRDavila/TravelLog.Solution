using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelLog.Models;
using System;
using System.Collections.Generic;

namespace TravelLog.Tests
{
  [TestClass]
  public class PlacesTests : IDisposable
  {
    public void Dispose()
    {
      Places.ClearAll();
    }

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

      [TestMethod]
      public void SetVisitDate_SetVisitDate_DateTime()
      {
        //Arrange
        string city = "Portland";
        DateTime visitDate = new DateTime(2020, 1, 1);
        Places newPlaces = new Places(city, visitDate);
        //Act
        DateTime updatedVisitDate = new DateTime(2020, 2, 1);
        newPlaces.VisitDate = updatedVisitDate;
        DateTime result = newPlaces.VisitDate;
        //Assert
        Assert.AreEqual(updatedVisitDate, result);
      }

      [TestMethod]
      public void GetRating_ReturnsRating_Int()
      {
        //Arrange
        string city = "Portland";
        DateTime visitDate = new DateTime(2020, 1, 1);
        int rating = 5;
        Places newPlaces = new Places(city, visitDate, rating);
        //Act
        int result = newPlaces.Rating;
        //Assert
        Assert.AreEqual(rating, result);
      }

      [TestMethod]
      public void SetRating_SetRating_Int()
      {
        //Arrange
        string city = "Portland";
        DateTime visitDate = new DateTime(2020, 1, 1);
        int rating = 5;
        Places newPlaces = new Places(city, visitDate, rating);
        //Act
        int updatedRating = 4;
        newPlaces.Rating = updatedRating;
        int result = newPlaces.Rating;
        //Assert
        Assert.AreEqual(updatedRating, result);
      }

      [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Places> newList = new List<Places> { };

      // Act
      List<Places> result = Places.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

      [TestMethod]
      public void GetAll_ReturnsPlacesList_PlacesList()
      {
        // Arrange
        DateTime testDate1 = new DateTime(2020, 1, 1);
        DateTime testDate2 = new DateTime(2020, 2, 1);
        string city1 = "Portland";
        string city2 = "Seattle";
        int rating1 = 5;
        int rating2 = 4;
        Places newPlaces1 = new Places(city1, testDate1, rating1);
        Places newPlaces2 = new Places(city2, testDate2, rating2);

        List<Places> newList = new List<Places> { newPlaces1, newPlaces2};
        // Act
        List<Places> result = Places.GetAll();
        // Assert
        CollectionAssert.AreEqual(newList, result);
      }

      public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
      {
        //Arrange
        DateTime testDate = new DateTime(2020, 1, 1);
        string city = "Portland";
        int rating = 5;
        Places newPlaces = new Places(city, testDate, rating);
        //Act
        int result = newPlaces.Id;
        //Assert
        Assert.AreEqual(1, result);
      }
    }
  }   
