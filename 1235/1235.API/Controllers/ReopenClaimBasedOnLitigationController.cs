using System;
using _1235.DTO;
using _1235.Service;
using Microsoft.AspNetCore.Mvc;

namespace _1235.API
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ReopenClaimBasedOnLitigationController : ControllerBase
    {
        private readonly ReopenClaimBasedOnLitigationService _service;
        public ReopenClaimBasedOnLitigationController()
        {
            _service = new ReopenClaimBasedOnLitigationService();
        }

        [HttpPost]
        public void Create(ReopenClaimBasedOnLitigation claim)
        {
            _service.Create(claim);
        }

        [HttpGet("{id}")]
        public ReopenClaimBasedOnLitigation Get(Guid id)
        {
            return _service.Get(id);
        }

        [HttpPut]
        public void Update(ReopenClaimBasedOnLitigation claim)
        {
            _service.Update(claim);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.Delete(id);
        }
    }
}