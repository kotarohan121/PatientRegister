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
    public class CitiesController : ControllerBase
    {

        // GET: api/Cities
        [HttpGet]
        public IEnumerable<Tblcity> GetCities()
        {            
            var cityLst = DBContext.GetData<iMedOneDB.Models.Tblcity>();

            return cityLst;
        }

    }
}