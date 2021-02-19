using Microsoft.AspNetCore.Mvc;
using NetflixWebApi.Context;
using NetflixWebApi.Entities;
using NetflixWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeriesController : ControllerBase
    {
        SeriesResponse _seriesResponse = null;

        public SeriesController(NetflixDB netflixDB)
        {
            _seriesResponse = new SeriesResponse(netflixDB);
        }

        [HttpGet(Name = nameof(getSeries))]
        public IActionResult getSeries()
        {
            var response = _seriesResponse.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult getByID(int id)
        {
            var response = _seriesResponse.GetById(id);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult postSeries([FromBody] SeriesEntity entity) {

            var response =_seriesResponse.Add(entity);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult deleteSeries(int id)
        {
            var response = _seriesResponse.Delete(id);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult deleteSeries([FromBody] SeriesEntity entity)
        {
            var response = _seriesResponse.Delete(entity);
            return Ok(response);
        }


        [HttpPut]
        public IActionResult updateSeries([FromBody] SeriesEntity entity)
        {
            var response = _seriesResponse.Update(entity);
            return Ok(response);
        }
    }
}
