using iMedOneDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientApi.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace PatientApi.Tests
{
    [TestClass]
    public class TestCitiesController
    {
        [TestMethod]
        public void GetTestCities()
        {
            var testCities = GetTestData();

            var controller = new CitiesController();
            var result = controller.GetCities();

            Assert.AreEqual(testCities.Count, result.Count());
        }

        private List<Tblcity> GetTestData()
        {
            var teststates = new List<Tblcity>();
            teststates.Add(new Tblcity { Id = 1, Name = "Pune", StateId=1 });
            teststates.Add(new Tblcity { Id = 2, Name = "Nagpur", StateId = 1 });
            teststates.Add(new Tblcity { Id = 3, Name = "Nagar", StateId = 1 });
            teststates.Add(new Tblcity { Id = 4, Name = "Akola", StateId = 1 });
            teststates.Add(new Tblcity { Id = 5, Name = "Ahmedabad", StateId = 2 });
            teststates.Add(new Tblcity { Id = 5, Name = "Surat", StateId = 2 });

            return teststates;
        }

    }

    }
