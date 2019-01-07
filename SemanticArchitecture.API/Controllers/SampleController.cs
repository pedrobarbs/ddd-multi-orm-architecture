using System;
using Microsoft.AspNetCore.Mvc;
using SemanticArchitecture.Application.Application_Services_Interfaces;
using SemanticArchitecture.Domain.Core.Domain_Entities;

namespace SemanticArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private ISampleApplicationService _sampleApplicationService;

        public SampleController(ISampleApplicationService sampleApplicationService)
        {
            _sampleApplicationService = sampleApplicationService;
        }

        // GET: api/Sample
        [HttpGet]
        public ActionResult Get()
        {
            var samples = _sampleApplicationService.GetAll();
            return Ok(samples);
        }

        // GET: api/Sample/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get([FromRoute] Guid id)
        {
            var sample = _sampleApplicationService.GetById(id);
            return Ok(sample);
        }

        // POST: api/Sample
        [HttpPost]
        public ActionResult Post([FromBody] Sample sample)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _sampleApplicationService.Add(sample);
            return CreatedAtAction("Get", new { id = sample.Id }, sample);
        }

        // PUT: api/Sample/5
        [HttpPut("{id}")]
        public ActionResult Put([FromRoute] Guid id, [FromBody] Sample sample)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            sample.Id = id;
            _sampleApplicationService.Update(sample);
            return Ok(sample);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] Guid id)
        {
            try
            {
                var sample = _sampleApplicationService.GetById(id);
                _sampleApplicationService.Remove(sample);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
