using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using iMedOneDB;
using iMedOneDB.Models;

namespace PatientApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {

        // GET: api/Patients
        [HttpGet]
        public IEnumerable<Tblstate> GetStates()
        {          
            var stateLst = DBContext.GetData<iMedOneDB.Models.Tblstate>();

            return stateLst;
        }


    }
}