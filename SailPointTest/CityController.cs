using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SailPointTest.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SailPointTest
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IRepository _repository;
        public CityController(IRepository repository)
        {
            _repository = repository;
        }
        [Route("{search}")]
        [HttpGet]
        public ActionResult Get(string search)
        {
            var result = _repository.GetCities(search);
            return Ok(result);
        }

    }

}
