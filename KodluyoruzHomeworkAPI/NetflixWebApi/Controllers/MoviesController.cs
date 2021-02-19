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
    public class MoviesController : ControllerBase
    {
        MovieResponse _movieResponse = null;

        public MoviesController(NetflixDB netflixDB)
        {
            _movieResponse = new MovieResponse(netflixDB);
        }

        [HttpGet(Name = nameof(getMovies))]
        public IActionResult getMovies()
        {
            var response = _movieResponse.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult getMovie(int id)
        {
            var response = _movieResponse.GetById(id);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult postMovie([FromBody] MovieEntity entity) {

            var response = _movieResponse.Add(entity);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult deleteMovie(int id)
        {
            var response = _movieResponse.Delete(id);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult deleteMovie([FromBody] MovieEntity entity)
        {
            var response = _movieResponse.Delete(entity);
            return Ok(response);
        }


        [HttpPut]
        public IActionResult updateMovie([FromBody] MovieEntity entity)
        {
            var response = _movieResponse.Update(entity);
            return Ok(response);
        }
    }
}
