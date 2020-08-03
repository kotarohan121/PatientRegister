using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using iMedOneDB;
using iMedOneDB.Models;


namespace PatientApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        // GET: api/Patients
        [HttpGet]
        public IEnumerable<TBLPATIENT> GetPatients()
        {
            var patientLst = DBContext.GetData<iMedOneDB.Models.TBLPATIENT>();          
            return patientLst;
        }


        // POST: api/Patients
        [HttpPost]
        public IActionResult PostPatient([FromBody] TBLPATIENT patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            List<TBLPATIENT> patientList = new List<TBLPATIENT>();
            patientList.Add(patient);

            DBContext.SaveAll<iMedOneDB.Models.TBLPATIENT>(patientList);

            return Ok();


        }


    }
}