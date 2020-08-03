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
    public class TestPatientsController
    {
        [TestMethod]
        public void GetTestPatients()
        {
          
            var controller = new PatientsController();
            var result = controller.GetPatients();
            Assert.IsTrue(result.Count() != 0);
           
        }

        [TestMethod]
        public void PostTestPatients()
        {
       

            var controller = new PatientsController();
            TBLPATIENT tBLPATIENT = new TBLPATIENT();
            tBLPATIENT.Id = 3;
            tBLPATIENT.Name = "David";
            tBLPATIENT.SurName = "Marta";
            tBLPATIENT.Gender = "M";
            tBLPATIENT.DOB = System.DateTime.Parse("1992-06-24T00:00:00");

            var result = controller.PostPatient(tBLPATIENT);
            var okResult = result as StatusCodeResult;
        
            Assert.AreEqual(200, okResult.StatusCode);
         
          
        }

     
    }

}
