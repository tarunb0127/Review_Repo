using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AvengersApp.Repositories;
using AvengersApp.Models;

namespace AvengersApp.Control
{

    [ApiController]
    [Route("api/[controller]")]

    public class AvengerController : ControllerBase
    {
        private readonly IAvengersRepocs _repository;
        public AvengerController(IAvengersRepocs repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<Avengers> GetAllAvengers() {
            return _repository.GetAllAvengers()
        }

        [HttpGet("{id}")]
        public ActionResult<Avengers> GetAvengersById(int id) {
           var avengerToFind = _repository.GetAvengersById(id);
            if (avengerToFind == null) { 
                return NoContent();
            }
            return avengerToFind;
        }

        [HttpPut]
        public void UpdateAvengers(int id)
        {
            _repository.UpdateAvengers(id);
            
        }
        [HttpPost]
        public void DeleteAvenger(int id)
        {
            _repository.DeleteAvengers(id);
        }

    }
        
}
