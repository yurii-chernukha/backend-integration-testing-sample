using System;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Services;

namespace MoviesApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieService _service;

        public MoviesController(MovieService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = _service.Get();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetSample(Guid id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }
    }
}
