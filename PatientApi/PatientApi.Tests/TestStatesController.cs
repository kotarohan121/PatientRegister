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
    public class TestStatesController
    {
        [TestMethod]
        public void GetTestStates()
        {
            var testPatients = GetTestData();

            var controller = new StatesController();
            var result = controller.GetStates();

            Assert.AreEqual(testPatients.Count, result.Count());
        }

        private List<Tblstate> GetTestData()
        {
            var teststates = new List<Tblstate>();
            teststates.Add(new Tblstate { Id = 1, Name = "MH" });
            teststates.Add(new Tblstate { Id = 2, Name = "GJ" });

            return teststates;
        }

    }

    }
